using System;
using System.Collections.Generic;
using Common;
using Models.Contratos;
using Models.Modelos;
using StructureUBL.CommonAggregateComponents;
using StructureUBL.CommonBasicComponents;
using StructureUBL.EstandarUbl;
using StructureUBL.SunatAggregateComponents;

namespace GenerateXML
{
    public class ResumenDiarioXml /*: IDocumentoXml*/
    {
        //IEstructuraXml IDocumentoXml.Generar(IDocumentoElectronico request)
        //{
        //    var documento = (ResumenDiario)request;
        //    var summary = new SummaryDocuments
        //    {
        //        Id = documento.SerieCorrelativo,
        //        IssueDate = Convert.ToDateTime(documento.FechaEmision),
        //        ReferenceDate = Convert.ToDateTime(documento.FechaReferencia),
        //        CustomizationId = "1.0",
        //        UblVersionId = "2.0",
        //        Signature = new SignatureCac
        //        {
        //            Id = documento.SerieCorrelativo,
        //            SignatoryParty = new SignatoryParty
        //            {
        //                PartyIdentification = new PartyIdentification
        //                {
        //                    Id = new PartyIdentificationId
        //                    {
        //                        Value = documento.Emisor.NroDocumento
        //                    }
        //                },
        //                PartyName = new PartyName
        //                {
        //                    Name = documento.Emisor.NombreLegal
        //                }
        //            },
        //            DigitalSignatureAttachment = new DigitalSignatureAttachment
        //            {
        //                ExternalReference = new ExternalReference
        //                {
        //                    Uri = $"{documento.Emisor.NroDocumento}-{documento.SerieCorrelativo}"
        //                }
        //            }
        //        },
        //        AccountingSupplierParty = new AccountingSupplierParty
        //        {
        //            CustomerAssignedAccountId = documento.Emisor.NroDocumento,
        //            AdditionalAccountId = documento.Emisor.TipoDocumento,
        //            Party = new Party
        //            {
        //                PartyLegalEntity = new PartyLegalEntity
        //                {
        //                    RegistrationName = documento.Emisor.NombreLegal
        //                }
        //            }
        //        }
        //    };

        //    foreach (var grupo in documento.Resumenes)
        //    {
        //        var linea = new VoidedDocumentsLine
        //        {
        //            LineId = grupo.Id,
        //            DocumentTypeCode = grupo.TipoDocumento,
        //            DocumentSerialId = grupo.Serie,
        //            StartDocumentNumberId = grupo.CorrelativoInicio,
        //            EndDocumentNumberId = grupo.CorrelativoFin,
        //            TotalAmount = new PayableAmount
        //            {
        //                CurrencyId = grupo.Moneda,
        //                Value = grupo.TotalVenta
        //            },
        //            BillingPayments = new List<BillingPayment>()
        //            {
        //              new BillingPayment
        //              {
        //                  PaidAmount = new PayableAmount
        //                  {
        //                      CurrencyId = grupo.Moneda,
        //                      Value = grupo.Gravadas
        //                  },
        //                  InstructionId = "01"
        //              },
        //              new BillingPayment
        //              {
        //                  PaidAmount = new PayableAmount
        //                  {
        //                      CurrencyId = grupo.Moneda,
        //                      Value = grupo.Exoneradas
        //                  },
        //                  InstructionId = "02"
        //              },
        //              new BillingPayment
        //              {
        //                  PaidAmount = new PayableAmount
        //                  {
        //                      CurrencyId = grupo.Moneda,
        //                      Value = grupo.Inafectas
        //                  },
        //                  InstructionId = "03"
        //              },
        //            },
        //            AllowanceCharge = new AllowanceCharge
        //            {
        //                ChargeIndicator = true,
        //                Amount = new PayableAmount
        //                {
        //                    CurrencyId = grupo.Moneda,
        //                    Value = grupo.TotalDescuentos
        //                }
        //            },
        //            TaxTotals = new List<TaxTotal>()
        //            {
        //                new TaxTotal
        //                {
        //                    TaxAmount = new PayableAmount
        //                    {
        //                        CurrencyId = grupo.Moneda,
        //                        Value = grupo.TotalIsc
        //                    },
        //                    TaxSubtotal = new TaxSubtotal
        //                    {
        //                        TaxAmount = new PayableAmount
        //                        {
        //                            CurrencyId = grupo.Moneda,
        //                            Value = grupo.TotalIsc
        //                        },
        //                        TaxCategory = new TaxCategory
        //                        {
        //                            TaxScheme = new TaxScheme
        //                            {
        //                                Id = "2000",
        //                                Name = "ISC",
        //                                TaxTypeCode = "EXC"
        //                            }
        //                        }
        //                    }
        //                },
        //                new TaxTotal
        //                {
        //                    TaxAmount = new PayableAmount
        //                    {
        //                        CurrencyId = grupo.Moneda,
        //                        Value = grupo.TotalIgv
        //                    },
        //                    TaxSubtotal = new TaxSubtotal
        //                    {
        //                        TaxAmount = new PayableAmount
        //                        {
        //                            CurrencyId = grupo.Moneda,
        //                            Value = grupo.TotalIgv
        //                        },
        //                        TaxCategory = new TaxCategory
        //                        {
        //                            TaxScheme = new TaxScheme
        //                            {
        //                                Id = "1000",
        //                                Name = "IGV",
        //                                TaxTypeCode = "VAT"
        //                            }
        //                        }
        //                    }
        //                },
        //                new TaxTotal
        //                {
        //                    TaxAmount = new PayableAmount
        //                    {
        //                        CurrencyId = grupo.Moneda,
        //                        Value = grupo.TotalOtrosImpuestos
        //                    },
        //                    TaxSubtotal = new TaxSubtotal
        //                    {
        //                        TaxAmount = new PayableAmount
        //                        {
        //                            CurrencyId = grupo.Moneda,
        //                            Value = grupo.TotalOtrosImpuestos
        //                        },
        //                        TaxCategory = new TaxCategory
        //                        {
        //                            TaxScheme = new TaxScheme
        //                            {
        //                                Id = "9999",
        //                                Name = "OTROS",
        //                                TaxTypeCode = "OTH"
        //                            }
        //                        }
        //                    }
        //                },
        //            }
        //        };
        //        if (grupo.Exportacion > 0)
        //        {
        //            linea.BillingPayments.Add(new BillingPayment
        //            {
        //                PaidAmount = new PayableAmount
        //                {
        //                    CurrencyId = grupo.Moneda,
        //                    Value = grupo.Exportacion
        //                },
        //                InstructionId = "04"
        //            });
        //        }
        //        if (grupo.Gratuitas > 0)
        //        {
        //            linea.BillingPayments.Add(new BillingPayment
        //            {
        //                PaidAmount = new PayableAmount
        //                {
        //                    CurrencyId = grupo.Moneda,
        //                    Value = grupo.Gratuitas
        //                },
        //                InstructionId = "05"
        //            });
        //        }
        //        summary.SummaryDocumentsLines.Add(linea);
        //    }

        //    return summary;
        //}
    }
}
