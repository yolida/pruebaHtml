using FEI.Extension.Base;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace FEI.Base
{
    public class clsBaseReporte
    {
        public static void cs_pxReporteCSV(DataGridView dgv, string archivo)
        {
            if (dgv.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dgvr = new DataGridViewRow();
                StreamWriter sw0 = new StreamWriter(archivo);
                
                for (int j = 0; j <= dgv.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        sw0.WriteLine();
                    }

                    dgvr = dgv.Rows[j];

                    for (int i = 0; i <= dgv.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            sw0.Write(";");
                        }
                        value = dgvr.Cells[i].Value.ToString();
                        value = value.Replace(';', ' ');
                        value = value.Replace(Environment.NewLine, " ");
                        sw0.Write(value);
                    }
                }
                sw0.Close();
                clsBaseMensaje.cs_pxMsgOk("OKE12");
            }
        }

        public static void cs_pxReportePDF(DataGridView dgv, string archivo)
        {
            try
            {
                if (dgv.Rows.Count>0)
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

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        PdfPCell cell_1 = new PdfPCell(new Phrase(row.Cells[2].Value.ToString(), fuente));
                        cell_1.BorderWidth = 1;
                        tblPdf.AddCell(cell_1);

                        PdfPCell cell_2 = new PdfPCell(new Phrase(row.Cells[3].Value.ToString(), fuente));
                        cell_2.BorderWidth = 1;
                        tblPdf.AddCell(cell_2);

                        PdfPCell cell_3 = new PdfPCell(new Phrase(row.Cells[4].Value.ToString(), fuente));
                        cell_3.BorderWidth = 1;
                        tblPdf.AddCell(cell_3);

                        PdfPCell cell_4 = new PdfPCell(new Phrase(row.Cells[5].Value.ToString(), fuente));
                        cell_4.BorderWidth = 1;
                        tblPdf.AddCell(cell_4);

                        PdfPCell cell_5 = new PdfPCell(new Phrase(row.Cells[6].Value.ToString(), fuente));
                        cell_5.BorderWidth = 1;
                        tblPdf.AddCell(cell_5);

                        PdfPCell cell_6 = new PdfPCell(new Phrase(row.Cells[7].Value.ToString(), fuente));
                        cell_6.BorderWidth = 1;
                        tblPdf.AddCell(cell_6);

                        PdfPCell cell_7 = new PdfPCell(new Phrase(row.Cells[8].Value.ToString(), fuente));
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
