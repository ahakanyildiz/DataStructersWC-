
using System;

namespace Queue
{
    public class CustomQueue
    {
        public Node Front;
        public Node Rear;

        public CustomQueue()
        {
            Front= null;
            Rear= null;
        }

        public int GetDataFromUser(string metin)
        {
            System.Console.WriteLine(metin);
            int data = int.Parse(Console.ReadLine());
            return data;
        }
        public void enQueue(int data)
        {
            Node dugum = new Node(data);
            if (Front == null)
            {
                Front = Rear = dugum;
                System.Console.WriteLine("Kuyruk oluşturuldu.İlk eleman eklendi.");
            }
            else
            {
                Rear.Next = dugum;
                Rear = dugum;
                System.Console.WriteLine("Ekleme yapıldı.");
            }
        }

        public int deQueue()
        {
            if (Front == null)
            {
                System.Console.WriteLine("Kuyruk boş.");
                return -1;
            }
            else
            {
                int data = Front.Data;
                Front=Front.Next;
                System.Console.WriteLine("Kuyruktan eleman çıkarıldı.");
                return data;
            }
        }

        public void PrintAllDatas()
        {
            if (Front == null)
            {
                System.Console.WriteLine("Kuyruk boş.");
            }
            else
            {

                Node victim = Front;
                System.Console.WriteLine("Bas . ");
                while (victim != null)
                {
                    System.Console.WriteLine(victim.Data + " <- ");
                    victim = victim.Next;
                }

                System.Console.WriteLine("Son.");
            }
        }

    }
}
