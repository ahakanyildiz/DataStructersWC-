using System;

namespace CustStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackYapisi stack = new StackYapisi();

            while (true)
            {
                Console.WriteLine("1-Push \n2-Pop \n3-Yazdır");
                Console.WriteLine("Yapmak istediğiniz işlemi seçin : ");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        stack.Push();
                        break;
                    case 2:
                        stack.Pop();
                        break;
                    case 3:
                        stack.StackYazdir();
                        break;
                }
            }
        }
    }
}
