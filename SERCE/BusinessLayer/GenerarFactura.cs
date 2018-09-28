using DataLayer.CRUD;
using GenerateXML;
using Models.Intercambio;
using Models.Modelos;
using Security;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GenerarFactura
    {
        private readonly IDocumentoXml _documentoXml;
        private readonly ISerializador _serializador;

        public GenerarFactura()
        {
            FacturaXml documentoElectronico = new FacturaXml();
            _documentoXml = (IDocumentoXml)documentoElectronico;

            Serializador serializador = new Serializador();
            _serializador = (ISerializador)serializador;
        }
        public string       IdDocumento     { get; set; }
        
        public DocumentoElectronico data(Data_Documentos data_Documento)
        {
            Data_CabeceraDocumento cabeceraDocumento    =   new Data_CabeceraDocumento(data_Documento.IdCabeceraDocumento);
            cabeceraDocumento.Read_CabeceraDocumento();

            var    documento    =   new DocumentoElectronico()  //    Documento principal
            {
                SerieCorrelativo    =   data_Documento.SerieCorrelativo,
                TipoDocumento       =   data_Documento.TipoDocumento ?? string.Empty,
                FechaEmision        =   cabeceraDocumento.FechaEmision,
                HoraEmision         =   cabeceraDocumento.HoraEmision,
                FechaVencimiento    =   cabeceraDocumento.FechaVencimiento,
                OrdenCompra         =   cabeceraDocumento.OrdenCompra,
                Moneda              =   cabeceraDocumento.Moneda,
                TipoOperacion       =   cabeceraDocumento.TipoOperacion,
                MontoEnLetras       =   cabeceraDocumento.MontoEnLetras ?? string.Empty,
                CantidadItems       =   cabeceraDocumento.CantidadItems,
                TotalValorVenta     =   cabeceraDocumento.TotalValorVenta,
                TotalPrecioVenta    =   cabeceraDocumento.TotalPrecioVenta,
                TotalDescuento      =   cabeceraDocumento.TotalDescuento,
                TotalOtrosCargos    =   cabeceraDocumento.TotalOtrosCargos,
                TotalAnticipos      =   cabeceraDocumento.TotalAnticipos,
                ImporteTotalVenta   =   cabeceraDocumento.ImporteTotalVenta
            };

            #region Emisor
            Data_Contribuyente Emisor   =   new Data_Contribuyente(data_Documento.IdEmisor);
            Emisor.Read_Contribuyente();
            documento.Emisor            =   Emisor;
            #endregion Emisor

            #region Receptor
            Data_Contribuyente Receptor =   new Data_Contribuyente(cabeceraDocumento.IdReceptor);
            Receptor.Read_Contribuyente();
            documento.Receptor          =   Receptor;
            documento.Receptor.OtrosParticipantes = new List<Contribuyente>();  //  Pendiente crear entidad OtrosParticipantes
            #endregion Receptor

            #region documentoDetalle
            Data_DocumentoDetalle data_DocumentoDetalle =   new Data_DocumentoDetalle(data_Documento.IdCabeceraDocumento);
            List<DetalleDocumento> detalleDocumentos    =   data_DocumentoDetalle.Read_DocumentoDetalle();

            if (detalleDocumentos.Count > 0)    //  Validar en caso de que no haya detalles del documento
            {
                foreach (var detalleDocumento in detalleDocumentos)
                {
                    Data_TotalImpuesto lineaTotalImpuesto   =   new Data_TotalImpuesto(detalleDocumento.IdDocumentoDetalle);
                    List<TotalImpuesto> lineaTotalImpuestos =   lineaTotalImpuesto.Read_TotalImpuestos(2);  //  El parámetro -> 2 <- es indicativo de que es por cada línea

                    foreach (var st_totalImpuesto in lineaTotalImpuestos)
                    {
                        Data_SubTotalImpuesto data_SubTotalImpuesto =   new Data_SubTotalImpuesto(st_totalImpuesto.IdTotalImpuestos);
                        List<SubTotalImpuestos> subTotalImpuestos   =   data_SubTotalImpuesto.Read_SubTotalImpuesto();
                        st_totalImpuesto.SubTotalesImpuestos        =   subTotalImpuestos;
                    }
                    detalleDocumento.TotalImpuestos =   lineaTotalImpuestos;
                    
                    #region emergency
                    List<Descripcion> descripciones = new List<Descripcion>();

                    Descripcion data_descripcion;
                    data_descripcion = new Descripcion() { Detalle = null ?? string.Empty };
                    descripciones.Add(data_descripcion);

                    detalleDocumento.Descripciones = descripciones;

                    List<PrecioAlternativo> precioAlternativos = new List<PrecioAlternativo>();
                    PrecioAlternativo data_precioAlternativo;

                    data_precioAlternativo = new PrecioAlternativo()
                    {
                        TipoMoneda = null,
                        Monto = null,
                        TipoPrecio = null
                    };
                    precioAlternativos.Add(data_precioAlternativo);

                    data_precioAlternativo = new PrecioAlternativo()
                    {
                        TipoMoneda = "01",
                        Monto = 15.47m,
                        TipoPrecio = "01"
                    };
                    precioAlternativos.Add(data_precioAlternativo);

                    detalleDocumento.PreciosAlternativos = precioAlternativos;

                    List<Descuento> descuentos = new List<Descuento>();

                    detalleDocumento.Descuentos = descuentos;

                    List<PropiedadAdicional> propiedadAdicionales = new List<PropiedadAdicional>();
                    detalleDocumento.PropiedadesAdicionales = propiedadAdicionales;

                    List<Entrega> entregas1 = new List<Entrega>();

                    Entrega data_entrega;
                    data_entrega = new Entrega()
                    {
                        Cantidad = 0,
                        MaximaCantidad = 0,
                        Envio = new Envio(),

                    };
                    entregas1.Add(data_entrega);

                    detalleDocumento.Entregas = entregas1;



                    #endregion emergency
                }
                documento.DetalleDocumentos     =   detalleDocumentos;
            }


            #endregion documentoDetalle

            #region TotalImpuestos
            Data_TotalImpuesto data_TotalImpuesto   =   new Data_TotalImpuesto(data_Documento.IdCabeceraDocumento);
            List<TotalImpuesto> totalImpuestos      =   data_TotalImpuesto.Read_TotalImpuestos(1);   //  El parámetro -> 1 <- es indicativo de que es por cada línea

            foreach (var st_totalImpuesto in totalImpuestos)
            {
                Data_SubTotalImpuesto data_SubTotalImpuesto =   new Data_SubTotalImpuesto(st_totalImpuesto.IdTotalImpuestos);
                List<SubTotalImpuestos> subTotalImpuestos   =   data_SubTotalImpuesto.Read_SubTotalImpuesto();
                st_totalImpuesto.SubTotalesImpuestos        =   subTotalImpuestos;
            }
            documento.TotalImpuestos = totalImpuestos;
            #endregion TotalImpuestos

            #region TerminosEntregas
            Data_TerminosEntrega data_TerminosEntrega   =   new Data_TerminosEntrega(data_Documento.IdCabeceraDocumento);
            data_TerminosEntrega.Read_TerminosEntrega();   //  El parámetro -> 1 <- es indicativo de que es por cada línea
            documento.TerminosEntrega                   =   data_TerminosEntrega;
            #endregion TerminosEntregas

            List<Nota> notas = null;
            List<PeriodoFactura> periodoFacturas = null;
            List<DocumentoRelacionado> documentoRelacionados = null;
            List<DocumentoRelacionado> otrosDocumentosRelacionados = null;
            List<Entrega> entregas = null;
            List<MedioPago> medioPagos = null;
            List<Anticipo> anticipos = null;
            List<Descuento> item_descuentos = null;

            documento.Notas = notas;
            documento.Relacionados = documentoRelacionados;
            documento.OtrosDocumentosRelacionados = otrosDocumentosRelacionados;
            documento.Entregas = entregas;
            documento.MedioPagos = medioPagos;
            documento.Anticipos = anticipos;
            documento.Descuentos = item_descuentos;
            documento.PeriodosFactura = periodoFacturas;

            return documento;
        }
        
        public async Task<DocumentoResponse> Post(DocumentoElectronico documento)
        {
            var response    =   new DocumentoResponse();
            try
            {
                var invoice                 =   _documentoXml.Generar(documento);
                response.TramaXmlSinFirma   =   await _serializador.GenerarXml(invoice);
                response.Exito              =   true;
            }
            catch (Exception ex)
            {
                response.MensajeError       =   ex.Message;
                response.Pila               =   ex.StackTrace;
                response.Exito              =   false;
            }

            return response;
        }
    }
}
