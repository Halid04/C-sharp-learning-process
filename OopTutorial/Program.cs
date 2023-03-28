using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Human human1 = new Human("Cissé","Halid","Black",1);
            human1.IntroduceMyself();

            Human human2 = new Human("Giulio", "Cesare", "blue", 40);
            human2.IntroduceMyself();

            Human human3 = new Human();
            human3.IntroduceMyself();

            Console.WriteLine("");

            Box box1 = new Box();
            box1.SetLunghezza(5);
            box1.SetAltezza(2);
            box1.SetLarghezza(3);
            Console.WriteLine("Il volume di box1 è: {0}", box1.GetVolume());
            box1.BoxInfo();

            Console.WriteLine("");

            Box box2 = new Box(7,2,4);
            Console.WriteLine("Il volume di box2 è: {0}", box2.GetVolume());
            box2.BoxInfo();


        }
    }
}
