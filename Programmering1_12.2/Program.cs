using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_12._1 {
    class Program {
        static void Main(string[] args) {
            string[] names = new string[5];
            Console.WriteLine("Skriv fem namn nedan: ");
            for(int i = 0; i < 5; i++) { // int i skapas. loopen pågår till i=4. i blir en större. (tills 4)
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("Tack!");
            Console.WriteLine();

            Console.Write("Här är namnen du skrev: ");
            for(int i = 0; i < 5; i++) {
                Console.Write(names[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
