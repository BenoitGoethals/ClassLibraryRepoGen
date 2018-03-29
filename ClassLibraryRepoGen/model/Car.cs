using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRepoGen.model
{
   public class Car: Item
    {
        public Car(int id, string name, int age, Status status) : base(id, name, age)
        {
            Status = status;
        }

        public Status Status { get; set; }


    }
}
