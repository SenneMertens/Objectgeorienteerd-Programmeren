using Zwembad_Models;

namespace Zwembad_Tests
{
    public class ZwembadTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LiterWater_BerekenInhoud_Resultaat()
        {
            Zwembad zwembad = new Zwembad();

            zwembad.Breedte = 6;
            zwembad.Diepte = 2;
            zwembad.Lengte = 8;
            zwembad.Randafstand = 0.3;

            Assert.AreEqual(zwembad.LiterWater(), 81600);
        }

        [Test]
        public void Breedte_ValueGroterDanNul_BreedteGelijkAanValue()
        {
            Zwembad zwembad = new Zwembad();

            zwembad.Breedte = -1;

            Assert.AreEqual(zwembad.Breedte, 0);
        }

        [Test]
        public void Diepte_ValueGroterDanNul_BreedteGelijkAanValue()
        {
            Zwembad zwembad = new Zwembad();

            zwembad.Diepte = -1;

            Assert.AreEqual(zwembad.Diepte, 0);
        }

        [Test]
        public void Lengte_ValueGroterDanNul_BreedteGelijkAanValue()
        {
            Zwembad zwembad = new Zwembad();

            zwembad.Lengte = -1;

            Assert.AreEqual(zwembad.Lengte, 0);
        }

        [Test]
        public void Randafstand_ValueGroterDanDiepte_RandafstandGelijkAanNul()
        {
            Zwembad zwembad = new Zwembad();

            zwembad.Randafstand = 2;
            zwembad.Diepte = 1;

            Assert.AreEqual(zwembad.Randafstand, 0);
        }
    }
}