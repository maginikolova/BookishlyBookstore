﻿using BookishlyBookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookishlyBookstore.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }

        public List<Book> Books { get; set; }

    }
}
