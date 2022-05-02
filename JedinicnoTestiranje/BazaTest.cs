using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoginForma;
using System.Data;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class BazaTest
    {
        [TestMethod]
        public void DohvacanjePodatakaIzBazeTest()
        {
            VlasnikaForma forma = new VlasnikaForma("mmaric");
            DataTable DT = forma.DohvacanjePodatakaIzBaze("SELECT * FROM Zgrada");
            Assert.IsNotNull(DT,"Fail!");

            DataTable DT2 = forma.DohvacanjePodatakaIzBaze("SELECT ZaposlenikID FROM Zgrada WHERE ID = 1");
            //Assert.IsNull(DT, "Null je");

            Assert.IsNotNull(DT2, "Fail!");

            DataTable DT3 = forma.DohvacanjePodatakaIzBaze("SELECT Ulaz.Oznaka AS OznakaUlaza, Kat.Oznaka AS OznakaKata, Stan.Oznaka AS OznakaStana, Stan.Dugovanje" +
                " FROM Zgrada INNER JOIN" +
                " Ulaz ON Zgrada.ID = Ulaz.ZgradaID INNER JOIN" +
                " Kat ON Ulaz.ID = Kat.UlazID INNER JOIN" +
                " Stan ON Kat.ID = Stan.KatID" +
                " WHERE(Zgrada.ID = 1)");
            bool prazanDataTable;
            if(DT3 != null)
            {
                prazanDataTable = true;
            }
            else
            {
                prazanDataTable = false;
            }
            Assert.IsTrue(prazanDataTable, "Fail");

            //DataTable DT4 = forma.DohvacanjePodatakaIzBaze("SELECT * FROM Zgrade"); // Krivo upisano "Zgrade", tocan naziv tablice je "Zgrada"
           
            //Assert.ThrowsException<System.Data.SqlClient.SqlException>(Action DT4, "Poruka!");
            
            
            
            //Assert.IsNull(DT4, "Fail!");

            //Assert.IsNotInstanceOfType(DT,, "Fail");
            Assert.IsInstanceOfType(DT, typeof(DataTable) , "Fail!");

            Assert.AreNotSame(DT, DT3);
           
        }
    }
}
