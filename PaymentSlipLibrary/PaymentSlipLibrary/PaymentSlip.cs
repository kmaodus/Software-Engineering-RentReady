using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PaymentSlipLibrary
{
    public class PaymentSlip
    {
        float iznosStanarine;
        string imePlatitelja;
        string prezimePlatitelja;
        string adresaPlatitelja;
        string gradPlatitelja;
        string ibanPlatitelja;
        string opisPlaćanja = "Uplata mjesečne stanarine.";
        public PaymentSlip(float iznos, string ime, string prezime, string adresa, string grad, string iban)
        {
            iznosStanarine = iznos;
            imePlatitelja = ime;
            prezimePlatitelja = prezime;
            adresaPlatitelja = adresa;
            gradPlatitelja = grad;
            ibanPlatitelja = iban;
        }

        public int GeneratePaymentSlip() {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Uplatnica.pdf", FileMode.Create));
            doc.Open(); //Otvara dokument za pisanje

            PdfPTable table = new PdfPTable(3);

            PdfPCell cell = new PdfPCell(new Phrase("NALOG ZA PLACANJE"));
            cell.BackgroundColor = new iTextSharp.text.BaseColor(250, 235, 215);
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);

            //PLATITELJ
            cell = new PdfPCell(new Phrase("PLATITELJ(naziv / ime i adresa):"));
            cell.BorderWidthBottom = 0;
            table.AddCell(cell);
            table.AddCell("Valuta plaćanja: HRK");
            table.AddCell("Iznos: " + iznosStanarine);

            cell = new PdfPCell(new Phrase(imePlatitelja + " " + prezimePlatitelja));
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("IBAN platitelja: " + ibanPlatitelja));
            cell.Colspan = 2;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(adresaPlatitelja + ", " + gradPlatitelja));
            cell.BorderWidthTop = 0;
            table.AddCell(cell);
            table.AddCell("Model: HR99");
            table.AddCell("Poziv na broj: ");

            //PRIMATELJ
            cell = new PdfPCell(new Phrase("PRIMATELJ(naziv / ime i adresa):"));
            cell.BorderWidthBottom = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase("IBAN primatelja: HR89327213214"));
            cell.Colspan = 2;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase(imePlatitelja + " " + prezimePlatitelja));
            cell.BorderWidthTop = 0;
            cell.BorderWidthBottom = 0;
            table.AddCell(cell);
            table.AddCell("Model: HR99");
            table.AddCell("Poziv na broj: 1552018");

            cell = new PdfPCell(new Phrase(adresaPlatitelja + ", " + gradPlatitelja));
            cell.BorderWidthTop = 0;
            table.AddCell(cell);
            DateTime danas = DateTime.Today;
            table.AddCell("Datum izvršenja: " + danas);
            table.AddCell(opisPlaćanja);

            doc.Add(table);

            doc.Close();

            return 0;
        }
        
    }
}
