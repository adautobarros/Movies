﻿using Movies.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class Screens
    {
        public readonly static string AbsoluteURI = "http://www.devwizza.com";

        public readonly static string MoviesHomeTabbedPage = nameof(MoviesHomeTabbedPage);

        public readonly static string ShowingNowNavigationPage = nameof(ShowingNowNavigationPage);

        public readonly static string ShowingNow = nameof(ShowingNow);

        public readonly static string MovieDetails = nameof(MovieDetails);
    }

    public class NavigationParametersKey
    {
        public readonly static string SelectedMovieId = nameof(SelectedMovieId);
    }

    public class ProjectJSONPaths
    {
        //assembly/folder/fileName.{extension}
        public readonly static string MoviesJSON = "Movies.MoviesJSON.movies.json";
    }
}
