using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbufGame.BLL
{
    internal class Tamagotchi
    {
        private int Healthbar { get; set; }
        private int Happinessbar { get; set; }
        private int Evolvebar { get; set; }
        private List<string> AnimalSelect { get; set; }
        private List<string> SetAnimalSelect(List<string> animalSelect)
        {
            AnimalSelect = animalSelect;

            animalSelect.Add("Fox");
            animalSelect.Add("Frog");
            animalSelect.Add("Sheep");
            animalSelect.Add("Dragon");

            return AnimalSelect;
        }

    }
}
