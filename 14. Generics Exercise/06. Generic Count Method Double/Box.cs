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
        private List<T> list;

        public Box()
        {
            this.list = new();
        }       

        public void Add(T item)
        {
            list.Add(item);
        }

        public int Compare(T comparedItem)
        {
            int count = 0;

            foreach (T item in list)
            {
                if (item.CompareTo(comparedItem) > 0)
                {
                    count++;
                }
            }

            return count;
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
