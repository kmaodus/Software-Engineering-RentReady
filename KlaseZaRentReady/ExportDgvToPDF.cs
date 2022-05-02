using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace KlaseZaRentReady
{
    public class ExportDgvToPDF
    {
        /// <summary>
        /// Metoda potreba za izvlačenje podataka iz zadanih DataGridView-a te tablični unos u novi PDF dokument uz prethodno dodani naslov
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="naslov"></param>
        public void ExportToPDF(DataGridView dgv, ComboBox cb)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftablica = new PdfPTable(dgv.ColumnCount);
            pdftablica.DefaultCell.Padding = 3;
            pdftablica.WidthPercentage = 100;
            pdftablica.HorizontalAlignment = Element.ALIGN_CENTER;
            pdftablica.DefaultCell.BorderWidth = 1;
            Font fontNaslova = new Font(bf, 32, Font.BOLD);
            Font fontOpisa = new Font(bf, 10, Font.NORMAL);

            Paragraph prazanRed = new Paragraph(Environment.NewLine);

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
            Paragraph naslovUDokumentu = new Paragraph("Popis troškova" + Environment.NewLine, fontNaslova);
            naslovUDokumentu.Alignment = Element.ALIGN_CENTER;

            Paragraph adresaZgrade = new Paragraph("Adresa zgrade: " + cb.GetItemText(cb.SelectedItem));

            Paragraph opisTvrtke = new Paragraph ("RentReady d.o.o. " + Environment.NewLine + "Pavlinska 2" + Environment.NewLine + "42000, Varaždin" + Environment.NewLine + "vgrbavac@rentready.com" + Environment.NewLine, fontOpisa);
            opisTvrtke.Alignment = Element.ALIGN_LEFT;

            Image slika = Image.GetInstance("D:\\Vedro\\Faks\\PI-Moje-Gotovo\\Dokumenti\\LogoAplikacije.png");
            slika.ScaleAbsolute(75, 75);
            slika.Alignment = Element.ALIGN_LEFT;

            Paragraph potpisi = new Paragraph("S poštovanjem, " + Environment.NewLine + "Vedran Grbavac" + Environment.NewLine + "____________________" + Environment.NewLine);

            DateTime danas = DateTime.Today;
            Paragraph datum = new Paragraph("U Varaždinu, " + danas.ToString("d") + Environment.NewLine);
            datum.Alignment = Element.ALIGN_RIGHT;

            double ukupnaDugovanja = 0;

            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftablica.AddCell(cell);
            }
            
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftablica.AddCell(new Phrase(cell.Value.ToString(), text));
                    if(cell.ColumnIndex == 3)
                    {
                        ukupnaDugovanja += double.Parse(cell.Value.ToString());
                    }
                }
            }

            Paragraph ukupanDug = new Paragraph("Ukupno dugovanje iznosi: " + ukupnaDugovanja + Environment.NewLine);
            ukupanDug.Alignment = Element.ALIGN_RIGHT;

            var savefiledialog = new SaveFileDialog();
            savefiledialog.DefaultExt = ".pdf";
            if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialog.FileName, FileMode.Create))
                {
                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(slika);
                    pdfdoc.Add(opisTvrtke);
                    pdfdoc.Add(naslovUDokumentu);
                    pdfdoc.Add(prazanRed);
                    pdfdoc.Add(adresaZgrade);
                    pdfdoc.Add(prazanRed);
                    pdfdoc.Add(pdftablica);
                    pdfdoc.Add(prazanRed);
                    pdfdoc.Add(ukupanDug);
                    pdfdoc.Add(prazanRed);
                    pdfdoc.Add(potpisi);
                    pdfdoc.Add(datum);
                    pdfdoc.Close();
                    stream.Close();
                }
            }
        }
    }
}
