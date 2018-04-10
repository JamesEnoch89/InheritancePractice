using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Robot : IPet
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int VersionNumber { get; set; }
        public string OwnersName { get; set; }
        private bool IsAsleep { get; set; }
        public Robot(string name)
        {
            Name = name;
            Birthday = DateTime.Now;
            IsAsleep = false;
            int count = 0;
            count++;
            VersionNumber = count;
        }

        public void GetWakeState()
        {
            if (this.IsAsleep == true)
            {
                Console.WriteLine($"{this.Name} is asleep");
            }else
            {
                this.SayHello();
            }

        }
        public void StartUp()
        {
            IsAsleep = false;
        }
        public void ShutDown()
        {
            IsAsleep = true;
        }
        public void SayHello()
        {
            Console.WriteLine("I AM ROBOT");
        }

        public override string ToString()
        {
            return $"Robot: {Name} {Birthday} {VersionNumber}";
        }
    }
}
    }
}
