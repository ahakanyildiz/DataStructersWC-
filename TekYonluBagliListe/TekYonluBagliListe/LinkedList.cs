
using System;

namespace TekYonluBagliListe
{
    public class LinkedList
    {
        public Node Head;

        public LinkedList()
        {
            Head = null;
        }

        public int GetData(string metin)
        {
            System.Console.WriteLine(metin);
            return int.Parse(Console.ReadLine());
        }

        public void AddToLast(int data)
        {
            Node dugum = new Node(data);
            if (Head == null)
            {
                System.Console.WriteLine("Liste oluşturuldu.İlk düğüm eklendi.");
                Head = dugum;
            }
            else
            {
                Node victim = Head;
                if (victim.Next != null)
                {
                    victim = victim.Next;
                }
                
                victim.Next = dugum;
                System.Console.WriteLine("Sona eklendi.");
            }
        }

        public void AddToStart(int data)
        {
            Node dugum = new Node(data);
            if (Head == null)
            {
                System.Console.WriteLine("Liste oluşturuldu. İlk Düğüm eklendi");
                Head = dugum;
            }
            else
            {
                Node victim = Head;
                dugum.Next = Head;
                Head = dugum;
            }
        }

        public void PrintAllDatas()
        {
            if (Head == null)
            {
                System.Console.WriteLine("Liste boş ");
                return;
            }
            Node victim = Head;
            System.Console.Write("Baş ==>");
            System.Console.Write("| ");
            while (victim != null)
            {
                System.Console.Write(victim.Data + " | ");
                victim = victim.Next;
            }
            Console.WriteLine();
        }

        public void DeleteFromStart()
        {
            int count = 0;
            if (Head == null)
            {
                System.Console.WriteLine("Liste boş.Silinecek eleman yok");
                return;
            }
            else if (Head.Next != null)
            {
                Head = null;
                Console.WriteLine("Listenin tek elemanı da silindi.");
            }
            else
            {
                Head = Head.Next;
                System.Console.WriteLine("Baştan silindi.");
            }
        }

        public void DeleteFromLast()
        {
            int count = 0;
            if (Head == null)
            {
                System.Console.WriteLine("Liste boş.Silinecek eleman yok");
                return;
            }
            else if (Head.Next == null)
            {
                Head = null;
                System.Console.WriteLine("Listede kalan son düğüm de silindi.");
            }
            else
            {
                Node victim = Head;
                Node victim2 = victim;
                while (victim.Next != null)
                {
                    victim2 = victim;
                    victim = victim.Next;
                }
                victim2.Next = null;
                System.Console.WriteLine("Sondan silindi.");
            }
        }

        public void DeleteBetween()
        {
            int indis = GetData("Silmek istediğiniz datanın indisini giriniz: ");
            Node victim = Head;
            Node victim2 = victim;
            int count = 0;
            if (Head == null)
            {
                System.Console.WriteLine("Listede şu an eleman yok.");
            }
            else if (indis == 0)
            {
                Head = Head.Next;
            }
            else
            {
                while (victim.Next != null)
                {      
                    if (count == indis)
                    {
                        break;
                    }
                    victim2 = victim;
                    victim = victim.Next;
                    count++;
                }
                if (victim.Next != null)
                {
                    victim2.Next = victim.Next;
                }
                else
                {
                    victim2.Next = null;
                }

            }

          
        }

        public void AddBetween()
        {
            int indis = GetData("Eklemek istediğiniz indis numarasını giriniz: ");
            int data = GetData("Eklemek istediğiniz sayinin verisini giriniz: ");
            Node dugum = new Node(data);
            if (Head == null)
            {
                Head = dugum;
            }
            else if (indis == 0)
            {
                dugum.Next = Head;
                Head = dugum;
            }
            else
            {
                int count = 0;
                Node victim = Head;
                while (victim.Next != null)
                {
                    if(count == indis)
                    {
                        dugum.Next = victim.Next;
                        victim.Next = dugum;
                        break;
                    }
                    victim = victim.Next;
                    count++;
                }
            }

        }
    }
}
