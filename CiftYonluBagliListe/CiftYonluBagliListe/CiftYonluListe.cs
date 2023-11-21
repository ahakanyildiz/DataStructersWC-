using System;

namespace CiftYonluBagliListe
{
    public class CiftYonluListe
    {
        public Node Head;

        public CiftYonluListe()
        {
            Head = null;
        }

        public int GetData(string metin)
        {
            System.Console.WriteLine(metin);
            int data = int.Parse(Console.ReadLine());
            return data;
        }
        public void AddToStart()
        {
            int data = GetData("Eklemek istediginiz verinin datasini giriniz : ");
            Node dugum = new Node(data, null, null);
            if (Head == null)
            {

                Head = dugum;
                Console.WriteLine("Liste oluşturuldu.İlk düğüm eklendi.");
            }
            else
            {
                Node victim = Head;
                Head.Prev = dugum;
                dugum.Next = Head;
                Head = dugum;
            }

        }
        public void AddToLast()
        {
            int data = GetData("Eklemek istediğiniz sayinin verisini giriniz: ");
            Node dugum = new Node(data, null, null);
            if (Head == null)
            {
                Head = dugum;
            }
            else if (Head.Next == null)
            {
                dugum.Prev = Head;
                Head.Next = dugum;
            }
            else
            {
                Node victim = Head;
                while (victim.Next != null)
                {
                    victim = victim.Next;
                }

                dugum.Prev = victim;
                victim.Next = dugum;

            }
        }
        public void PrintAllDatas()
        {
            if (Head == null)
            {
                Console.WriteLine("Listede hiç eleman yok.");
            }
            else if (Head.Next == null)
            {
                Console.WriteLine(Head.Data);
            }
            else
            {
                Node victim = Head;
                Console.Write("Baş ==> | ");
                while (victim.Next != null)
                {
                    Console.Write(victim.Data + "| ");
                    victim = victim.Next;
                }
                Console.Write(victim.Data + " | ");
                Console.WriteLine();
            }
        }
        public void DeleteBetween()
        {
            int indis = GetData("Silmek istediğiniz sayinin indisini giriniz: ");

            if (Head != null)
            {
                Console.WriteLine("Listede eleman yok");
            }
            else if (indis == 0)
            {
                Head = null;
            }
            else
            {
                int count = 0;
                Node victim = Head;
                while (victim.Next != null)
                {
                    if (count == indis)
                    {
                        break;
                    }
                    victim = victim.Next;
                    count++;
                }

                victim.Next.Prev = victim.Prev;
                victim.Prev.Next = victim.Next.Prev;
            }
        }
        public void DeleteFromStart()
        {
          

            if (Head != null)
            {
                Console.WriteLine("Listede eleman yok");
            }
            else if (Head.Next == null)
            {
                Head = null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
        }
        public void DeleteFromLast()
        {
            if (Head != null)
            {
                Console.WriteLine("Listede eleman yok");
            }
            else if (Head.Next == null)
            {
                Head = null;
            }
            else
            {
                Node victim = Head;
                while (victim.Next != null)
                {
                    victim= victim.Next;
                }
                victim.Prev.Next = null;
                victim = null;
            }
        }
        public void AddBetween()
        {
            int data = GetData("Eklemek istediğiniz verinin sayisini giriniz : ");
            int indis = GetData("Eklemek istediğiniz veri için indis giriniz : ");
            Node dugum = new Node(data,null,null);
            if (Head == null)
            {
                Head = dugum;
            }
            else if (indis==0)
            {
                dugum.Next = Head;
                Head= dugum;
            }
            else
            {
                Node victim = Head;
                int count = 0;
                while (victim.Next != null)
                {
                    if (indis == count)
                    {
                        break;
                    }

                    victim = victim.Next;
                    count++;
                }

                if (victim.Next != null)
                {
                    victim.Next.Prev = dugum;
                    dugum.Next = victim.Next;
                    victim.Next = dugum;
                }
                else
                {
                    victim.Next= dugum;
                    dugum.Prev = victim;
                }
            }
        }

    }
}
