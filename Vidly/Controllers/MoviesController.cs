﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {


        public ActionResult Index()
        {
            var movie = GetMovies();
            if (!movie.Any())
                return HttpNotFound();

            return View(movie);
        }
        
        

        
       


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek"},
                new Movie { Id = 2, Name = "Wall-e"}

            };


        }


       
    }
}