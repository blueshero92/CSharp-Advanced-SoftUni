using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        public List<T> list;

        public Box()
        {
            this.list = new();
        }       

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Compare(T comparedItem, List<T> list)
        {
            int count = 0;

            foreach (T item in list)
            {
                if (item.CompareTo(comparedItem) > 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in list)
            {
                sb.AppendLine($"{typeof(T)}: {item.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
