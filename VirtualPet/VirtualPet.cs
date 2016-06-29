using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        public int Hunger { get; set; }
        public int Playfulness { get; set; }
        public int Energy { get; set; }

        private int _TempHunger { get; set; }
        private int _TempPlayfulness { get; set; }
        private int _TempEnergy { get; set; }

        public VirtualPet()
        {
            Hunger = 20;
            _TempHunger = 20;
            Playfulness = 10;
            _TempPlayfulness = 10;
            Energy = 25;
            _TempEnergy = 25;
        }

        public string TakeForWalk()
        {
            string result = "";
            if (Energy <= 5)
            {
                result = "Pet is too tired to go for a walk.";
            }
            else if (Energy > 5 && Energy < 20)
            {
                result = "Pet went for a short walk";
                _TempEnergy -= 5;
                _TempPlayfulness -= 5;
                _TempHunger += 5;
            }
            else
            {
                result = "Pet went for a long walk";
                _TempEnergy -= 10;
                _TempPlayfulness -= 10;
                _TempHunger += 10;
            }
            return result;
        }

        public string FeedPet()
        {
            string result = "";
            if (Hunger > 25)
            {
                result = "Pet ate a lot and is asking for more";
                _TempHunger -= 15;
                _TempEnergy += 10;
                _TempPlayfulness += 10;
            }
            else if (Hunger > 15)
            {
                result = "Pet ate some";
                _TempHunger -= 10;
                _TempEnergy += 5;
                _TempPlayfulness += 5;
            }
            else
            {
                result = "Pet doesn't want to eat";
            }
            return result;
        }

        public string Play()
        {
            string result = "";
            if (Playfulness > 20 && Energy > 20)
            {
                result = "Pet plays for a long time";
                _TempPlayfulness -= 10;
                _TempEnergy -= 10;
                _TempHunger += 5;
            }
            else if (Playfulness > 10 && Energy > 10)
            {
                result = "Pet played a little";
                _TempPlayfulness -= 5;
                _TempEnergy -= 5;
            }
            else
            {
                result = "Pet doesn't want to play";
            }
            return result;
        }

        public void Tick()
        {
            Hunger = _TempHunger;
            Energy = _TempEnergy;
            Playfulness = _TempPlayfulness;
        }
    }
}
