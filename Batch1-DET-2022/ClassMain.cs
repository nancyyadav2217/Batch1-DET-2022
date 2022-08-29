using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class ClassMain
    {
        public static Student Student { get; private set; }

        public static void Main()
        {
            ScienceStudent Student = new ScienceStudent { regno = 12, Name = "Nancy" };
            ScienceStudent sciencesubject = new ScienceStudent { physics = 44, chemistry = 65, maths = 45 };
            CommerceStudent Commercessubject = new CommerceStudent { economices = 54, accounts = 82, banking = 74 };

            Console.WriteLine(sciencesubject.GetAvgMarks());
            Console.WriteLine(Commercessubject.GetAvgMarks());
        }
    }
}

    

