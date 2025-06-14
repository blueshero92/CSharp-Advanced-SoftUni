﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    internal class Box<T>
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
