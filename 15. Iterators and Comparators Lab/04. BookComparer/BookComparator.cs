﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators;

public class BookComparator : IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        if (x.Title.CompareTo(y.Title) != 0)
        {
            return x.Title.CompareTo(y.Title);
        }

        return y.Year.CompareTo(x.Year);
        //int result = x.Title.CompareTo(y.Title);

        //if (result == 0)
        //{
        //    result = x.Year.CompareTo(y.Year);
        //}

        //return result;
    }
}
