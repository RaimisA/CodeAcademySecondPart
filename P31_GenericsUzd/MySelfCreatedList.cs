using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_GenericsUzd
{
    public class MySelfCreatedList<T>
    {
        private T[] Myarray { get; set; }
        private int Index = 0;
        private int Size = 10;
        
        public MySelfCreatedList()
        {
            Myarray = new T[Size];
        }
        public void AddElement(T elementToAdd)
        {
            if (CheckIfFull())
            {
                Myarray = IncreaseListSize();
            }
            if (elementToAdd != null)
            {
                Myarray[Index] = elementToAdd;
                Index++;
            }
            else
            {   
                throw new ArgumentNullException(nameof(elementToAdd), "Element cannot be null.");
            }
        }
        public void DeleteElement(T elementToDelete)
        {
            if (elementToDelete != null)
            {
                for (int i = 0; i < Index; i++)
                {
                    if (Myarray[i].Equals(elementToDelete))
                    {
                        Myarray[i] = default(T);
                        Index--;
                        break;
                    }
                }
            }
            else
            {
                throw new ArgumentNullException(nameof(elementToDelete), "Element cannot be null.");
            }
        }
        private bool CheckIfFull()
        {
            if (Index == Size)
                return true;
            else
                return false;
        }
        private T[] IncreaseListSize()
        {
            Size += Size + 1;
            var newArray = new T[Size];
            newArray.CopyTo(Myarray, 0);
            return newArray;    
        }
        public void Print()
        {
            foreach (var item in Myarray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
