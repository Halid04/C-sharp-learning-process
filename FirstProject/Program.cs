using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject{
    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("Inserisci il primo numero: ");
            string num1Input = Console.ReadLine();
            Console.WriteLine("Inserisci il secondo numero: ");
            string num2Input = Console.ReadLine();

            try
            {
                
                int num1 = int.Parse(num1Input);
                int num2 = int.Parse(num2Input);
                int container = num1;

                Console.WriteLine("Prima dello swap, num 1: "+num1+" e num 2: "+num2);
                num1 = num2;
                num2 = container;
                Console.WriteLine("Dopo lo swap, num 1: " + num1 + " e num 2: " + num2);
            
                Console.WriteLine(litteOperation(num1,num2));


                Console.WriteLine("Inserirsci il tuo nome:");
                string input = Console.ReadLine();
                Console.WriteLine("Ciao "+input);

                if (num1 > num2)
                {
                    Console.WriteLine("Il primo numero è maggiore del seconodo");
                }else if(num1 == num2)
                {
                    Console.WriteLine("I due numeri sono uguali");
                }
                else
                {
                    Console.WriteLine("Il secondo numero è più grande del primo");
                }

                var boh = num1 > num2 ? "num1 è più grande" : num1 < num2 ? "num2 è più grande" : "i due numeri sono uguali";
                Console.WriteLine(boh);

                for(int i=1; i<21; i++)
                {
                    var oddNum = i % 2 == 1 ? "odd number: "+i : "not an odd number";
                    Console.WriteLine(oddNum);

                }
            }
            catch(Exception)
            {
                Console.WriteLine("Rip Qualcosa è andato storto :)");
            }

          
            


        }

        public static int litteOperation(int num1, int num2)
        {
            Console.WriteLine("La somma di questi due numeri è:");
            return num1 + num2;

        }
    }
}
