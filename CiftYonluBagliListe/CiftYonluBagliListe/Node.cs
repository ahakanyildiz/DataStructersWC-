

namespace CiftYonluBagliListe
{
    public class Node
    {
        public int Data;
        public Node Prev;
        public Node Next;

        public Node(int data, Node prev, Node next)
        {
            this.Data = data;
            this.Prev = prev;
            this.Next = next;
        }
    }
}
