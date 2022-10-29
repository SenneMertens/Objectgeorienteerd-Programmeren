using Trein_Models;

namespace Trein_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Versnellen_ValueIsGroterDanNul_SnelheidVermeerdertMetValue()
        {
            Trein trein = new Trein();

            trein.Versnellen(20);

            Assert.AreEqual(20, trein._snelheid);
        }

        [Test]
        public void Remmen_ValueIsGroterDanNul_SnelheidVermindertMetValue()
        {
            Trein trein = new Trein();
            
            trein._snelheid = 40;
            trein.Remmen(20);

            Assert.AreEqual(20, trein._snelheid);
        }

        [Test]
        public void Afstappen_DeurOpen_PassagiersVermindertMetValue()
        {
            Trein trein = new Trein();

            trein._deurOpen = true;
            trein._passagiers = 40;
            trein.Afstappen(20);

            Assert.AreEqual(20, trein._passagiers);
        }

        [Test]
        public void Opstappen_DeurOpen_PassagiersVermeerdertMetValue()
        {
            Trein trein = new Trein();

            trein._deurOpen = true;
            trein._passagiers = 0;
            trein.Opstappen(20);

            Assert.AreEqual(20, trein._passagiers);
        }

        [Test]
        public void DeurGesloten_DeurOpen_DeurSluit()
        {
            Trein trein = new Trein();

            trein._deurOpen = true;
            trein.SluitDeur();

            Assert.AreEqual(trein._deurOpen, false);
        }

        [Test]
        public void Stoppen_TreinStopt_SnelheidIsGelijkAanNul()
        {
            Trein trein = new Trein();

            trein._snelheid = 100;
            trein.Stoppen();

            Assert.AreEqual(trein._snelheid, 0);
        }
    }
}