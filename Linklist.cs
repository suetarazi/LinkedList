using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{ 
public class Linklist
{
        public Node Head { get; set; }
        private Node Current { get; set; }



        //Method to insert a new node at the beginning of the LinkedList
        public void Insert(int value)
        {
            
            Node node = new Node();

            node.Value = value;

            node.Next = Head;

        
        Head = node;

        }

        public bool Includes(int value)
        {

            Current = Head;


            while(Current != null)
            {

                if (Current.Value == value)
                {
                    return true;
                }

                Current = Current.Next;
            }

            return false;

        }

        public override string ToString()
        {

            Current = Head;

            StringBuilder sb = new StringBuilder();

            while (Current != null)
            {
                sb.Append($"{Current.Value} -> ");
                Current = Current.Next;

            }

            sb.Append("NULL");
            return sb.ToString;

        }

}
}
