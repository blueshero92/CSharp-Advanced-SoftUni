﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Book
    {
        private string title;
        private int year;
        private List<string> authors;

        public Book(string title, int year, params string[] authors)
        {
            this.title = title;
            this.year = year;
            this.authors = authors.ToList();
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public List<string> Authors
        {
            get { return this.authors; }
            set { this.authors = value; }
        }
    }


}
