

namespace CustStack
{
    public class StackYapisi
    {
        public Node Top;
        public int count;
        public StackYapisi()
        {
            Top = null;
            count= 0;
        }

        public void Push()
        {
            System.Console.WriteLine("Eklemek istediğiniz sayiyi giriniz: ");
            int data = int.Parse(System.Console.ReadLine());
            Node dugum = new Node(data);
            if (Top == null)
            {
                Top = dugum;
                System.Console.WriteLine("Stack yapısı oluşturuldu, ilk eleman eklendi.");
            }
            else
            {
                dugum.Next = Top;
                Top = dugum;    
            }
        }

        public int Pop()
        {
            if (Top == null)
            {
                return -1;
            }
            else if (Top.Next == null)
            {
                int data = Top.Data;
                Top = null;
                return data;
            }
            else
            {
                int data = Top.Data;
                Top = Top.Next;
                return data;
            }
        }


        public void StackYazdir()
        {
            if (Top == null)
            {
                System.Console.WriteLine("Stack boş. Yazdırılacak eleman yok.");
            }
            else
            {
                int data =default;
                while (data != -1)
                {
                    data = Pop();
                    if (data != -1)
                    {
                        System.Console.WriteLine(data);
                    }
                  
                }
            }
        }
    }
}
