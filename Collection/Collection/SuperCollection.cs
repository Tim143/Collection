using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Collection
{
    public class SuperCollection<T> :ISuperCollection<T>
    {
        private int index = 0;
        private T[] arr;

        public SuperCollection()
        {
            arr = new T[10];
        }
        
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public void Reset()
        {
            index = 0;
        }

        public bool MoveNext()
        {
            if (index < arr.Length)
            {
                index++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public object Current { get; }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public void RemoveAllElements()
        {
            arr = null;
        }

        public void RemoveElement()
        {
            for (int i = 0; i < arr.Length; i++)
            {
               Console.WriteLine($"{i+1}.{arr[i]}");
            }
            
            Console.Write("Enter number of element, that you want to delete:  ");
            int index = int.Parse(Console.ReadLine());
            Console.Clear();
            
            T[] tmpArray = new T[arr.Length];
            for (int i = 0; i < tmpArray.Length; i++)
            {
                if (index!=i+1)
                {
                    tmpArray[i] = arr[i];
                }
            }
            
            for (int i = 0; i < tmpArray.Length; i++)
            {
                arr[i]=tmpArray[i];
            }
        }

        public void AddElement(T element)
        {
            if (index == arr.Length)
            {
                Array.Resize(ref arr,arr.Length*2);
                arr[index] = element;
            }
            else
            {
                arr[index] = element;
            }

            index++;
        }

        public void FindElement()
        {
            throw new NotImplementedException();
        }

        public void ShowCollection()
        {
            if (arr.Length==0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your collection is empty.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.ResetColor();
            }
        }
    }
}