using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Program
    {
        private Stack<int> pila1 = new Stack<int>();
        private Stack<int> pila2 = new Stack<int>();
        static void Main(string[] args)
        {
           /* Program program = new Program();
            program.Insert(10);
            program.Insert(20);
            Console.WriteLine($"The queue is empty {program.IsEmpty()}"); 
            Console.WriteLine($"The first number is {program.Seek()}"); 

            Console.ReadLine();*/
            
        }
        public void Insert(int x)
        {
            pila1.Push(x);
        }
        public int Delete()
        {

            if (pila1.Count == 1)
            {
                return pila1.Pop();
            }
            else
            {
                Transfer();
                int result = pila2.Pop();
                Restore();
                return result;
            }
        }
        public int Seek()
        {
            if(pila1.Count == 0)
            {
                throw new ArgumentException("The queue is empty");
            }
            if (pila1.Count == 1)
            {
                return pila1.Peek();
            }
            else
            {
                Transfer();
                int result = pila2.Peek();
                Restore();
                return result;

            }
        }

        public void Restore()
        {
            while (pila2.Count > 0)
            {
                pila1.Push(pila2.Pop());

            }
        }

        public void Transfer()
        {
            while (pila1.Count > 0)
            {
                pila2.Push(pila1.Pop());
            }
        }

        public bool IsEmpty()
        {
            return pila1.Count == 0;
        }

      
    }
}
