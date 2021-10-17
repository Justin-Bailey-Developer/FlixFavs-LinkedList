using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlixFavs
{
    public class LinkedList<T>
    {

        private cNode<T> head;
        private cNode<T> tail;
        private cNode<T> current;
        private int size;

        public class cNode<R>
        {

            public cNode<R> next;
            public cNode<R> previous;
            public R data;

            public cNode(R r)
            {
                next = null;
                previous = null;
                data = r;
            }
        }
              
        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public T this[int i]
        {
            get
            {
                cNode<T> temp = head;

                if (i > size)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    for(int k = 0; k < i; k++)
                    {
                        temp = temp.next;
                    }
                }
                return temp.data;
            }
        }

        public T getFirst()
        {
            return head.data;
        }

        public T getLast()
        {
            return tail.data;
        }

        public T setCurrent()
        {
            current = head;
            return current.data;
        }

        public T getCurrent()
        {            
            return current.data;
        }

        public T getNext()
        {
            current = current.next;
            return current.data;
        }

        public T getPrevious()
        {
            current = current.previous;
            return current.data;
        }

        //public void Append(MovieNode n)
        public void Append(T t)
        {
            cNode<T> node = new cNode<T>(t);

            if (IsEmpty())
            {
                head = node;
                tail = node;
                current = node;
            }
            else
            {

                tail.next = node;
                node.previous = tail;
                tail = node;
                tail.next = head;
                head.previous = tail;
            }
            size++;
        }

        public void Prepend(T t)
        {
            cNode<T> node = new cNode<T>(t);

            if (IsEmpty())
            {
                head = node;
                tail = node;
                current = node;
            }
            else
            {
                node.next = head;
                head.previous = node;
                head = node;
                head.previous = tail;
            }
            size++;
        }

        public override string ToString()
        {
            string output = "";
                        
            cNode<T> current = head;
                               
            do
            {
                output += current.data.ToString() + Environment.NewLine;
                current = current.next;
            } while (current != head);

            return output;            
        }
    }
}
