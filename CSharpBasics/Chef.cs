using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad");
        }

        public virtual void MakeSpecialDish() // overwritable in subclasses
        {
            Console.WriteLine("The Chef makes BBQ ribs");
        }
    }
}
