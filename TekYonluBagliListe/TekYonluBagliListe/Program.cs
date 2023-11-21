using System;

namespace TekYonluBagliListe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.AddToStart(5);
            list.AddToStart(40);
            list.AddToStart(120);
            while (true)
            {
                Console.WriteLine("------------------MENU------------------------");
                Console.WriteLine("1-Başa Ekle\n2-Sona Ekle\n3-Listeyi listele\n4-Baştan Sil\n5-Sondan Sil \n 6-Aradan Sil\n 7-Araya Ekle");
                Console.WriteLine("Yapmak istediğiniz işlemi seçin: ");
                int secim =int.Parse(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        
                        list.AddToStart(list.GetData("Eklemek istediğiniz sayinin datasini giriniz: "));
                        break;
                    case 2:
                        list.AddToLast(list.GetData("Eklemek istediğiniz sayinin datasini giriniz: "));
                        break;
                    case 3:
                        list.PrintAllDatas();
                        break;
                    case 4:
                        list.DeleteFromStart();
                        break;
                    case 5:
                        list.DeleteFromLast();
                        break;
                    case 6:
                        list.DeleteBetween();
                        break;
                    case 7:
                        list.AddBetween();
                        break;
                }
            }
          
        }
    }
}
