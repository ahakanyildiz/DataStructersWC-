using System;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomQueue queue = new CustomQueue();

            while (true)
            {
                Console.WriteLine("1-Eleman ekle\n2-Eleman Çıkar\n3-Yazdır");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: ");
                int secim = int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        queue.enQueue(queue.GetDataFromUser("Eklemek istediğiniz sayiyi giriniz: "));
                        break;
                    case 2:
                        queue.deQueue();
                        break;
                    case 3:
                        queue.PrintAllDatas();
                        break;
                }
            }
        }
    }
}
