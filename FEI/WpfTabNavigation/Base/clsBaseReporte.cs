using FEI.Extension.Base;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FEI.Base
{
    public class clsBaseReporte
    {
      
        public static void cs_pxReporteCSV(List<ReporteDocumento> dgv, string archivo)
        {
            if (dgv.Count > 0)
            {
                string value = "";
              
                StreamWriter sw0 = new StreamWriter(archivo);

                foreach (ReporteDocumento item in dgv)
                {
                  
                    sw0.WriteLine();
                    value = item.TipoTexto + ";" + item.Tipo + ";" + item.EstadoSCC + ";" + item.EstadoSunat + ";" + item.FechaEmision + ";" + item.FechaEnvio + ";" + item.Comentario;
                    sw0.Write(value);
                    
                }
                sw0.Close();
                clsBaseMensaje.cs_pxMsgOk("OKE12");
            }
        }

        public static void cs_pxReportePDF(List<ReporteDocumento> dgv, string archivo)
        {
            try
            {
                if (dgv.Count > 0)
                {
                    Document doc = new Document(PageSize.A4.Rotate());

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(archivo, FileMode.Create));
                    doc.Open();
                    doc.Add(new Paragraph("LISTADO DE COMPROBANTES ELECTRÓNICOS - FEI", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.BLACK)));
                    doc.Add(Chunk.NEWLINE);

                    Font fuente = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);

                    PdfPTable tblPdf = new PdfPTable(7);
                    tblPdf.WidthPercentage = 100;

                    PdfPCell cell_c1 = new PdfPCell(new Phrase("COMPROBANTE", fuente));
                    cell_c1.BackgroundColor = BaseColor.GRAY;
                    cell_c1.BorderWidth = 1;
                    tblPdf.AddCell(cell_c1);

                    PdfPCell cell_c2 = new PdfPCell(new Phrase("ESTADO SCC", fuente));
                    cell_c2.BackgroundColor = BaseColor.GRAY;
                    cell_c2.BorderWidth = 1;
                    tblPdf.AddCell(cell_c2);

                    PdfPCell cell_c3 = new PdfPCell(new Phrase("ESTADO SUNAT", fuente));
                    cell_c3.BackgroundColor = BaseColor.GRAY;
                    cell_c3.BorderWidth = 1;
                    tblPdf.AddCell(cell_c3);

                    PdfPCell cell_c4 = new PdfPCell(new Phrase("SERIE - NÚMERO", fuente));
                    cell_c4.BackgroundColor = BaseColor.GRAY;
                    cell_c4.BorderWidth = 1;
                    tblPdf.AddCell(cell_c4);

                    PdfPCell cell_c5 = new PdfPCell(new Phrase("FECHA DE EMSIÓN", fuente));
                    cell_c5.BackgroundColor = BaseColor.GRAY;
                    cell_c5.BorderWidth = 1;
                    tblPdf.AddCell(cell_c5);

                    PdfPCell cell_c6 = new PdfPCell(new Phrase("RUC", fuente));
                    cell_c6.BackgroundColor = BaseColor.GRAY;
                    cell_c6.BorderWidth = 1;
                    tblPdf.AddCell(cell_c6);

                    PdfPCell cell_c7 = new PdfPCell(new Phrase("RAZÓN SOCIAL", fuente));
                    cell_c7.BackgroundColor = BaseColor.GRAY;
                    cell_c7.BorderWidth = 1;
                    tblPdf.AddCell(cell_c7);

                    foreach (ReporteDocumento row in dgv)
                    {
                        PdfPCell cell_1 = new PdfPCell(new Phrase(row.SerieNumero, fuente));
                        cell_1.BorderWidth = 1;
                        tblPdf.AddCell(cell_1);

                        PdfPCell cell_2 = new PdfPCell(new Phrase(row.EstadoSCC, fuente));
                        cell_2.BorderWidth = 1;
                        tblPdf.AddCell(cell_2);

                        PdfPCell cell_3 = new PdfPCell(new Phrase(row.EstadoSunat, fuente));
                        cell_3.BorderWidth = 1;
                        tblPdf.AddCell(cell_3);

                        PdfPCell cell_4 = new PdfPCell(new Phrase(row.SerieNumero, fuente));
                        cell_4.BorderWidth = 1;
                        tblPdf.AddCell(cell_4);

                        PdfPCell cell_5 = new PdfPCell(new Phrase(row.FechaEmision, fuente));
                        cell_5.BorderWidth = 1;
                        tblPdf.AddCell(cell_5);

                        PdfPCell cell_6 = new PdfPCell(new Phrase(row.Ruc, fuente));
                        cell_6.BorderWidth = 1;
                        tblPdf.AddCell(cell_6);

                        PdfPCell cell_7 = new PdfPCell(new Phrase(row.RazonSocial, fuente));
                        cell_7.BorderWidth = 1;
                        tblPdf.AddCell(cell_7);
                    }
                    doc.Add(tblPdf);

                    doc.Close();
                    writer.Close();

                    clsBaseMensaje.cs_pxMsgOk("OKE12");
                }
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR14", ex.ToString());
            }
        }
        public static void cs_pxReporteCSV_General(List<ReporteGeneral> dgvF, List<ReporteGeneral> dgvB,string archivo)
        {
            if (dgvF.Count > 0 && dgvB.Count > 0)
            {
                string value = "";

                StreamWriter sw0 = new StreamWriter(archivo);
                sw0.WriteLine();
                value = "Tipo de Comprobante Facturas;Codigo;Aceptados;Rechazados;Sin Estado;De Baja;Emitidos";
                sw0.Write(value);
                foreach (ReporteGeneral item in dgvF)
                {
                    sw0.WriteLine();
                    value = item.TipoTexto + ";" + item.Tipo + ";" + item.Aceptado + ";" + item.Rechazado + ";" + item.SinEstado + ";" + item.DeBaja + ";" + item.Emitidos;
                    sw0.Write(value);
                }
                sw0.WriteLine();
                value = "Tipo de Comprobante Boletas;Codigo;Aceptados;Rechazados;Sin Estado;De Baja;Emitidos";
                sw0.Write(value);
                foreach (ReporteGeneral item in dgvB)
                {
                    sw0.WriteLine();
                    value = item.TipoTexto + ";" + item.Tipo + ";" + item.Aceptado + ";" + item.Rechazado + ";" + item.SinEstado + ";" + item.DeBaja + ";" + item.Emitidos;
                    sw0.Write(value);
                }
                sw0.Close();
                clsBaseMensaje.cs_pxMsgOk("OKE12");
            }
        }

        public static void cs_pxReportePDF_General(List<ReporteGeneral> dgvF, List<ReporteGeneral> dgvB, string archivo)
        {
            try
            {
                if (dgvF.Count > 0 && dgvB.Count > 0)
                {
                    Document doc = new Document(PageSize.A4.Rotate());

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(archivo, FileMode.Create));
                    doc.Open();
                    doc.Add(new Paragraph("REPORTE GENERAL COMPROBANTES ELECTRÓNICOS - FEI", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.BLACK)));
                    doc.Add(Chunk.NEWLINE);

                    Font fuente = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);

                    PdfPTable tblPdf = new PdfPTable(7);
                    tblPdf.WidthPercentage = 100;
                   
                    PdfPCell cell_c1 = new PdfPCell(new Phrase("COMPROBANTE", fuente));
                    cell_c1.BackgroundColor = BaseColor.GRAY;
                    cell_c1.BorderWidth = 1;
                    tblPdf.AddCell(cell_c1);

                    PdfPCell cell_c2 = new PdfPCell(new Phrase("CODIGO", fuente));
                    cell_c2.BackgroundColor = BaseColor.GRAY;
                    cell_c2.BorderWidth = 1;
                    tblPdf.AddCell(cell_c2);

                    PdfPCell cell_c3 = new PdfPCell(new Phrase("ACEPTADOS", fuente));
                    cell_c3.BackgroundColor = BaseColor.GRAY;
                    cell_c3.BorderWidth = 1;
                    tblPdf.AddCell(cell_c3);

                    PdfPCell cell_c4 = new PdfPCell(new Phrase("RECHAZADOS", fuente));
                    cell_c4.BackgroundColor = BaseColor.GRAY;
                    cell_c4.BorderWidth = 1;
                    tblPdf.AddCell(cell_c4);

                    PdfPCell cell_c5 = new PdfPCell(new Phrase("SIN ESTADO", fuente));
                    cell_c5.BackgroundColor = BaseColor.GRAY;
                    cell_c5.BorderWidth = 1;
                    tblPdf.AddCell(cell_c5);

                    PdfPCell cell_c6 = new PdfPCell(new Phrase("DE BAJA", fuente));
                    cell_c6.BackgroundColor = BaseColor.GRAY;
                    cell_c6.BorderWidth = 1;
                    tblPdf.AddCell(cell_c6);

                    PdfPCell cell_c7 = new PdfPCell(new Phrase("EMITIDOS", fuente));
                    cell_c7.BackgroundColor = BaseColor.GRAY;
                    cell_c7.BorderWidth = 1;
                    tblPdf.AddCell(cell_c7);

                    PdfPCell cell_titulo_factura = new PdfPCell(new Phrase("Facturas electronicas", fuente));
                    cell_titulo_factura.BackgroundColor = BaseColor.DARK_GRAY;
                    cell_titulo_factura.BorderWidth = 1;
                    cell_titulo_factura.Colspan = 7;
                    tblPdf.AddCell(cell_titulo_factura);

                    foreach (ReporteGeneral row in dgvF)
                    {
                        PdfPCell cell_1 = new PdfPCell(new Phrase(row.TipoTexto, fuente));
                        cell_1.BorderWidth = 1;
                        tblPdf.AddCell(cell_1);

                        PdfPCell cell_2 = new PdfPCell(new Phrase(row.Tipo, fuente));
                        cell_2.BorderWidth = 1;
                        tblPdf.AddCell(cell_2);

                        PdfPCell cell_3 = new PdfPCell(new Phrase(row.Aceptado, fuente));
                        cell_3.BorderWidth = 1;
                        tblPdf.AddCell(cell_3);

                        PdfPCell cell_4 = new PdfPCell(new Phrase(row.Rechazado, fuente));
                        cell_4.BorderWidth = 1;
                        tblPdf.AddCell(cell_4);

                        PdfPCell cell_5 = new PdfPCell(new Phrase(row.SinEstado, fuente));
                        cell_5.BorderWidth = 1;
                        tblPdf.AddCell(cell_5);

                        PdfPCell cell_6 = new PdfPCell(new Phrase(row.DeBaja, fuente));
                        cell_6.BorderWidth = 1;
                        tblPdf.AddCell(cell_6);

                        PdfPCell cell_7 = new PdfPCell(new Phrase(row.Emitidos, fuente));
                        cell_7.BorderWidth = 1;
                        tblPdf.AddCell(cell_7);
                    }
                    PdfPCell cell_titulo_boletas = new PdfPCell(new Phrase("Boletas de Venta ", fuente));
                    cell_titulo_boletas.BackgroundColor = BaseColor.DARK_GRAY;
                    cell_titulo_boletas.BorderWidth = 1;
                    cell_titulo_boletas.Colspan = 7;
                    tblPdf.AddCell(cell_titulo_boletas);
                    foreach (ReporteGeneral row in dgvB)
                    {
                        PdfPCell cell_1 = new PdfPCell(new Phrase(row.TipoTexto, fuente));
                        cell_1.BorderWidth = 1;
                        tblPdf.AddCell(cell_1);

                        PdfPCell cell_2 = new PdfPCell(new Phrase(row.Tipo, fuente));
                        cell_2.BorderWidth = 1;
                        tblPdf.AddCell(cell_2);

                        PdfPCell cell_3 = new PdfPCell(new Phrase(row.Aceptado, fuente));
                        cell_3.BorderWidth = 1;
                        tblPdf.AddCell(cell_3);

                        PdfPCell cell_4 = new PdfPCell(new Phrase(row.Rechazado, fuente));
                        cell_4.BorderWidth = 1;
                        tblPdf.AddCell(cell_4);

                        PdfPCell cell_5 = new PdfPCell(new Phrase(row.SinEstado, fuente));
                        cell_5.BorderWidth = 1;
                        tblPdf.AddCell(cell_5);

                        PdfPCell cell_6 = new PdfPCell(new Phrase(row.DeBaja, fuente));
                        cell_6.BorderWidth = 1;
                        tblPdf.AddCell(cell_6);

                        PdfPCell cell_7 = new PdfPCell(new Phrase(row.Emitidos, fuente));
                        cell_7.BorderWidth = 1;
                        tblPdf.AddCell(cell_7);
                    }
                    doc.Add(tblPdf);
                    doc.Close();
                    writer.Close();

                    clsBaseMensaje.cs_pxMsgOk("OKE12");
                }
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR14", ex.ToString());
            }
        }
        public static void cs_pxReporteCSV_resumen(List<ReporteResumen> dgv, string archivo)
        {
            if (dgv.Count > 0)
            {
                string value = "";

                StreamWriter sw0 = new StreamWriter(archivo);

                foreach (ReporteResumen item in dgv)
                {

                    sw0.WriteLine();
                    value = item.Archivo + ";" + item.Ticket + ";" + item.EstadoSCC + ";" + item.EstadoSunat + ";" + item.FechaEmision + ";" + item.FechaEnvio + ";" + item.Comentario;
                    sw0.Write(value);

                }
                sw0.Close();
                clsBaseMensaje.cs_pxMsgOk("OKE12");
            }
        }

        public static void cs_pxReportePDF_resumen(List<ReporteResumen> dgv, string archivo)
        {
            try
            {
                if (dgv.Count > 0)
                {
                    Document doc = new Document(PageSize.A4.Rotate());

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(archivo, FileMode.Create));
                    doc.Open();
                    doc.Add(new Paragraph("LISTADO DE RESUMENES DIARIOS - FEI", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.BLACK)));
                    doc.Add(Chunk.NEWLINE);

                    Font fuente = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);

                    PdfPTable tblPdf = new PdfPTable(7);
                    tblPdf.WidthPercentage = 100;

                    PdfPCell cell_c1 = new PdfPCell(new Phrase("COMPROBANTE", fuente));
                    cell_c1.BackgroundColor = BaseColor.GRAY;
                    cell_c1.BorderWidth = 1;
                    tblPdf.AddCell(cell_c1);

                    PdfPCell cell_c2 = new PdfPCell(new Phrase("TICKET", fuente));
                    cell_c2.BackgroundColor = BaseColor.GRAY;
                    cell_c2.BorderWidth = 1;
                    tblPdf.AddCell(cell_c2);

                    PdfPCell cell_c3 = new PdfPCell(new Phrase("ESTADO SCC", fuente));
                    cell_c3.BackgroundColor = BaseColor.GRAY;
                    cell_c3.BorderWidth = 1;
                    tblPdf.AddCell(cell_c3);

                    PdfPCell cell_c4 = new PdfPCell(new Phrase("ESTADO SUNAT", fuente));
                    cell_c4.BackgroundColor = BaseColor.GRAY;
                    cell_c4.BorderWidth = 1;
                    tblPdf.AddCell(cell_c4);

                    PdfPCell cell_c5 = new PdfPCell(new Phrase("FECHA DE EMSIÓN", fuente));
                    cell_c5.BackgroundColor = BaseColor.GRAY;
                    cell_c5.BorderWidth = 1;
                    tblPdf.AddCell(cell_c5);

                    PdfPCell cell_c6 = new PdfPCell(new Phrase("FECHA DE ENVIO", fuente));
                    cell_c6.BackgroundColor = BaseColor.GRAY;
                    cell_c6.BorderWidth = 1;
                    tblPdf.AddCell(cell_c6);

                    PdfPCell cell_c7 = new PdfPCell(new Phrase("COMENTARIO", fuente));
                    cell_c7.BackgroundColor = BaseColor.GRAY;
                    cell_c7.BorderWidth = 1;
                    tblPdf.AddCell(cell_c7);

                    foreach (ReporteResumen row in dgv)
                    {
                        PdfPCell cell_1 = new PdfPCell(new Phrase(row.Archivo, fuente));
                        cell_1.BorderWidth = 1;
                        tblPdf.AddCell(cell_1);

                        PdfPCell cell_2 = new PdfPCell(new Phrase(row.Ticket, fuente));
                        cell_2.BorderWidth = 1;
                        tblPdf.AddCell(cell_2);

                        PdfPCell cell_3 = new PdfPCell(new Phrase(row.EstadoSCC, fuente));
                        cell_3.BorderWidth = 1;
                        tblPdf.AddCell(cell_3);

                        PdfPCell cell_4 = new PdfPCell(new Phrase(row.EstadoSunat, fuente));
                        cell_4.BorderWidth = 1;
                        tblPdf.AddCell(cell_4);

                        PdfPCell cell_5 = new PdfPCell(new Phrase(row.FechaEmision, fuente));
                        cell_5.BorderWidth = 1;
                        tblPdf.AddCell(cell_5);

                        PdfPCell cell_6 = new PdfPCell(new Phrase(row.FechaEnvio, fuente));
                        cell_6.BorderWidth = 1;
                        tblPdf.AddCell(cell_6);

                        PdfPCell cell_7 = new PdfPCell(new Phrase(row.Comentario, fuente));
                        cell_7.BorderWidth = 1;
                        tblPdf.AddCell(cell_7);
                    }
                    doc.Add(tblPdf);

                    doc.Close();
                    writer.Close();

                    clsBaseMensaje.cs_pxMsgOk("OKE12");
                }
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR14", ex.ToString());
            }
        }
        public static void cs_pxReporteCSV_baja(List<ReporteResumen> dgv, string archivo)
        {
            if (dgv.Count > 0)
            {
                string value = "";

                StreamWriter sw0 = new StreamWriter(archivo);

                foreach (ReporteResumen item in dgv)
                {

                    sw0.WriteLine();
                    value = item.Archivo + ";" + item.Ticket + ";" + item.EstadoSCC + ";" + item.EstadoSunat + ";" + item.FechaEmision + ";" + item.FechaEnvio + ";" + item.Comentario;
                    sw0.Write(value);

                }
                sw0.Close();
                clsBaseMensaje.cs_pxMsgOk("OKE12");
            }
        }

        public static void cs_pxReportePDF_baja(List<ReporteResumen> dgv, string archivo)
        {
            try
            {
                if (dgv.Count > 0)
                {
                    Document doc = new Document(PageSize.A4.Rotate());

                    PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(archivo, FileMode.Create));
                    doc.Open();
                    doc.Add(new Paragraph("LISTADO DE COMUNICACIONES DE BAJA - FEI", new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.BLACK)));
                    doc.Add(Chunk.NEWLINE);

                    Font fuente = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);

                    PdfPTable tblPdf = new PdfPTable(7);
                    tblPdf.WidthPercentage = 100;

                    PdfPCell cell_c1 = new PdfPCell(new Phrase("COMPROBANTE", fuente));
                    cell_c1.BackgroundColor = BaseColor.GRAY;
                    cell_c1.BorderWidth = 1;
                    tblPdf.AddCell(cell_c1);

                    PdfPCell cell_c2 = new PdfPCell(new Phrase("TICKET", fuente));
                    cell_c2.BackgroundColor = BaseColor.GRAY;
                    cell_c2.BorderWidth = 1;
                    tblPdf.AddCell(cell_c2);

                    PdfPCell cell_c3 = new PdfPCell(new Phrase("ESTADO SCC", fuente));
                    cell_c3.BackgroundColor = BaseColor.GRAY;
                    cell_c3.BorderWidth = 1;
                    tblPdf.AddCell(cell_c3);

                    PdfPCell cell_c4 = new PdfPCell(new Phrase("ESTADO SUNAT", fuente));
                    cell_c4.BackgroundColor = BaseColor.GRAY;
                    cell_c4.BorderWidth = 1;
                    tblPdf.AddCell(cell_c4);

                    PdfPCell cell_c5 = new PdfPCell(new Phrase("FECHA DE EMSIÓN", fuente));
                    cell_c5.BackgroundColor = BaseColor.GRAY;
                    cell_c5.BorderWidth = 1;
                    tblPdf.AddCell(cell_c5);

                    PdfPCell cell_c6 = new PdfPCell(new Phrase("FECHA DE ENVIO", fuente));
                    cell_c6.BackgroundColor = BaseColor.GRAY;
                    cell_c6.BorderWidth = 1;
                    tblPdf.AddCell(cell_c6);

                    PdfPCell cell_c7 = new PdfPCell(new Phrase("COMENTARIO", fuente));
                    cell_c7.BackgroundColor = BaseColor.GRAY;
                    cell_c7.BorderWidth = 1;
                    tblPdf.AddCell(cell_c7);

                    foreach (ReporteResumen row in dgv)
                    {
                        PdfPCell cell_1 = new PdfPCell(new Phrase(row.Archivo, fuente));
                        cell_1.BorderWidth = 1;
                        tblPdf.AddCell(cell_1);

                        PdfPCell cell_2 = new PdfPCell(new Phrase(row.Ticket, fuente));
                        cell_2.BorderWidth = 1;
                        tblPdf.AddCell(cell_2);

                        PdfPCell cell_3 = new PdfPCell(new Phrase(row.EstadoSCC, fuente));
                        cell_3.BorderWidth = 1;
                        tblPdf.AddCell(cell_3);

                        PdfPCell cell_4 = new PdfPCell(new Phrase(row.EstadoSunat, fuente));
                        cell_4.BorderWidth = 1;
                        tblPdf.AddCell(cell_4);

                        PdfPCell cell_5 = new PdfPCell(new Phrase(row.FechaEmision, fuente));
                        cell_5.BorderWidth = 1;
                        tblPdf.AddCell(cell_5);

                        PdfPCell cell_6 = new PdfPCell(new Phrase(row.FechaEnvio, fuente));
                        cell_6.BorderWidth = 1;
                        tblPdf.AddCell(cell_6);

                        PdfPCell cell_7 = new PdfPCell(new Phrase(row.Comentario, fuente));
                        cell_7.BorderWidth = 1;
                        tblPdf.AddCell(cell_7);
                    }
                    doc.Add(tblPdf);

                    doc.Close();
                    writer.Close();

                    clsBaseMensaje.cs_pxMsgOk("OKE12");
                }
            }
            catch (Exception ex)
            {
                clsBaseMensaje.cs_pxMsgEr("ERR14", ex.ToString());
            }
        }
    }
}
