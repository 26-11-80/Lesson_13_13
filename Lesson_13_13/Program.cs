using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_13_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул.Барвинка, 47", 30, 40, 50);
            Console.WriteLine(building.Print());
            MultiBuilding MultiBuilding = new MultiBuilding("ул.Постовского 17А", 40, 50, 60);
            Console.ReadKey();
        }
    }
}



       