using System;
using LaborationInterfaces;

namespace Olsson_Mikael
{
    public class Laboration_3d : ILaboration_3_StackInt
    {
        /// <summary>
        /// Pushes <paramref name="element"/> onto the stack. 
        /// </summary>
        /// <param name="arr">The array to be sorted.</param>
        public void Push(int element)
        {

        }

        /// <summary>
        /// Returns the uppermost element on the stack, without modifying the stack.
        /// </summary>
        /// <returns>The uppermost element on the stack.</returns>
        /// <exception cref="StackEmptyException">Thrown if method is called when stack is empty.</exception>
        public int Top()
        {
            return 0;
        }

        /// <summary>
        /// Removes the uppermost element on the stack, and returns it.
        /// </summary>
        /// <returns>The removed element.</returns>
        /// <exception cref="StackEmptyException">Thrown if method is called when stack is empty.</exception>
        public int Pop()
        {
            return 0;
        }

        /// <summary>
        /// Removes all elements on the entire stack.
        /// </summary>
        public void Clear()
        {

        }

        /// <summary>
        /// Returns the number of elements on the stack.
        /// </summary>
        /// <returns>The number of elements.</returns>
        public uint Size() { 
            return 0; 
        }
    }
}
