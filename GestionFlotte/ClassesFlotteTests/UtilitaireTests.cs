using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesFlotte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFlotte.Tests
{
    [TestClass()]
    public class UtilitaireTests
    {
        [TestMethod()]
        public void ChargeUtileTest()
        {
            //Utilitaire u = new Utilitaire
        }

        [TestMethod()]
        public void PrevoirEntretienTest()
        {
            // cas 1 : le véhicule est a entretenir
            Utilitaire u1 = new Utilitaire(1700, 1000, 5, "AA-123-CC", "Essence", 5);
            //int chargeUtileKg = u1.;
            

            //cas 2 : le 
        }
    }
}