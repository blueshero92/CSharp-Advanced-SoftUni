using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
    internal class CustomTuple<T1, T2>
    {
        private T1 item1;
        private T2 item2;

        public CustomTuple(T1 item1, T2 item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

        public T1 Item1
        {
            get { return this.item1; }
            set { this.item1 = value; }
        }

        public T2 Item2
        {
            get { return this.item2; }
            set { this.item2 = value; }
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Item1} -> {this.Item2}");

            return sb.ToString().TrimEnd();
        }
    }
}
