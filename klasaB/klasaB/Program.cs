using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaB
{
    class KlasaB
    {
        public string BezPrvogIZadnjeg(string bpiz)
        {
            bpiz = bpiz.Remove(bpiz.Length - 1, 1);
            bpiz = bpiz.Remove(0, 1);
            return bpiz;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaB klasaB = new KlasaB();
            Console.WriteLine("Unesi niz znakova: ");
            string s = Console.ReadLine();
            Console.WriteLine(klasaB.BezPrvogIZadnjeg(s));
            Console.ReadKey();
        }
    }
}
