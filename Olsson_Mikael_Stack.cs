using System;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    /// <summary>
    /// Defines an exception to be used with the stack. 
    /// </summary>
    public class StackEmptyException : Exception
    { }


    public class Mikael_Olsson_Stack : ILaboration_3_StackInt
    {

        internal class Node
        {
            internal int Data { get; set; }
            internal Node Next { get; set; }
        }

        private readonly Node top;

        private uint counter;

        public Mikael_Olsson_Stack()
        {
            top = new Node();
            top.Data = default;
            top.Next = null;
            counter = 0;
        }        


        /// <summary>
        /// Pushes <paramref name="element"/> onto the stack. 
        /// </summary>
        /// <param name="element">The element to be added.</param>
        public void Push(int element)
        {
            Node newNode = new Node();
            newNode.Data = element;
            newNode.Next = top.Next;
            top.Next = newNode;
            counter++;
        }

        /// <summary>
        /// Returns the uppermost element on the stack, without modifying the stack.
        /// </summary>
        /// <returns>The uppermost element on the stack.</returns>
        /// <exception cref="StackEmptyException">Thrown if method is called when stack is empty.</exception>
        public int Top()
        {
            Node returnNode = top.Next;
            if (returnNode != null)
            {
                return returnNode.Data;
            }
            else
            {
                throw new StackEmptyException();
            }
           //return 0;
        }

        /// <summary>
        /// Removes the uppermost element on the stack, and returns it.
        /// </summary>
        /// <returns>The removed element.</returns>
        /// <exception cref="StackEmptyException">Thrown if method is called when stack is empty.</exception>
        public int Pop()
        {
            Node returnNode = top.Next;
            if(top.Next != null)
            {
                top.Next = top.Next.Next;
                counter--;
                return returnNode.Data;
            }
            else
            {
                throw new StackEmptyException();
            }
            //return default;
        }

        /// <summary>
        /// Removes all elements on the entire stack.
        /// </summary>
        public void Clear()
        {
            top.Next = null;
            counter = 0;
        }

        /// <summary>
        /// Returns the number of elements on the stack.
        /// </summary>
        /// <returns>The number of elements.</returns>
        public uint Size() {
            return counter; 
        }
    }
}
