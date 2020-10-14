﻿using MovieRent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRent.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}