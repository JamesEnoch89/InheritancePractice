using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Human
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public List<IPet> Pets { get; set; } = new List<IPet>();
        private bool IsAsleep { get; set; }
        public Human(string name)
        {
            Name = name;
            Birthday = DateTime.Now;
        }
        public void WakeUp()
        {
            IsAsleep = false;
        }
        public void FallAsleep()
        {
            IsAsleep = true;
        }
        public string Eat(string food)
        {
            return ($"Eating: { food}");
        }
        public void SayHello()
        {
            Console.WriteLine("Should I be vegan?!?!");
        }

        public void Adopt(IPet pet)
        {
            pet.OwnersName = this.Name;
            this.Pets.Add(pet);
        }

        public override string ToString()
        {
            return $"Human: {Name} {Birthday} {IsAsleep}";
        }
    }
}
