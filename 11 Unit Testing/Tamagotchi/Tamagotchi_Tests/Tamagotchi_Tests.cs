using Tamagotchi_Models;

namespace Tamagotchi_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Eten_HongerVermeedert_HongerVermeerdertMetDrie()
        {
            Tamagotchi tamagotchi = new Tamagotchi($"Ori");

            tamagotchi.Eten(5);

            Assert.AreEqual(tamagotchi._goedGevoel, 3);
        }

        [Test]
        public void Liefkozen_GoedGevoelVermeedert_GoedGevoelVermeerdertMetEen()
        {
            Tamagotchi tamagotchi = new Tamagotchi($"Ori");

            tamagotchi.LiefKozen();

            Assert.AreEqual(tamagotchi._goedGevoel, 1);
        }

        [Test]
        public void Straffen_GoedGevoelVermindert_GoedGevoelVermindertMetValue()
        {
            Tamagotchi tamagotchi = new Tamagotchi($"Ori");

            tamagotchi._goedGevoel = 1;
            tamagotchi.Straffen(1);

            Assert.AreEqual(tamagotchi._goedGevoel, 0);
        }

        [Test]
        public void Gevoel_GoedGevoelVermindert_GoedGevoelVermindertMetEen()
        {
            Tamagotchi tamagotchi = new Tamagotchi($"Ori");

            tamagotchi._goedGevoel = 1;
            tamagotchi.Gevoel();

            Assert.AreEqual(tamagotchi._goedGevoel, 0);
        }
    }
}