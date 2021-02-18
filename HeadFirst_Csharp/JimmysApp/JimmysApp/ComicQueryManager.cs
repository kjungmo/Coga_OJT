﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace JimmysApp
{

    class ComicQueryManager
    {

        public ObservableCollection<ComicQuery> AvailableQueries { get; private set; }

        public ObservableCollection<object> CurrentQueryResults { get; private set; }

        public string Title { get;  private set; }

        public ComicQueryManager()
        {
            UpdateAvailableQueries();
            CurrentQueryResults = new ObservableCollection<object>();
        }

        private void UpdateAvailableQueries()
        {
            AvailableQueries = new ObservableCollection<ComicQuery>{
                new ComicQuery("LINQ makes queries easy", "A sample query", "Let's show Jimmy how flexible LINQ is", "Assets/purple_250x250.jpg"),
                new ComicQuery("Expensive comics", "Comics over $500", "Comics whose value is over 500 bucks." + " Jimmy can use this to figure out which comics are most coveted.", "Assets/captain_amazing_250x250.jpg"),
                new ComicQuery("LINQ is versatile 1", "Modify every item returned from the query", "This code will add a string onto the end of each string in an array.", "Assets/bluegray_250x250.jpg"),
                new ComicQuery("LINQ is versatile 2", "Perform calculations on collections", "LINQ provides extension methods for your collections (and anything else" + " that implements IEnumerable<T>).", "Assets/purple_250x250.jpg"),
                new ComicQuery("LINQ is versatile 3", "Store all or part of your results in a new sequence", "Sometimes you'll want to keep your results from a LINQ query around.", "Assets/bluegray_250x250.jpg"),
            };
        }

        public void UpdateQueryResults(ComicQuery query)
        {
            Title = query.Title;

            switch (query.Title)
            {
                case "LINQ makes queries easy": LinqMakesQueriesEasy(); break;
                case "Expensive comics": ExpensiveComics(); break;
            }
        }

        public static IEnumerable<Comic> BuildCatalog()
        {
            return new List<Comic>{
                new Comic { Name = "Johnny America vs. the Pinko", Issue = 6},
                new Comic { Name = "Rock and Roll ( limited edition)", Issue = 19},
                new Comic { Name = "Woman's Work", Issue = 36},
                new Comic { Name = "Hipple Madness (misprinted)", Issue = 57},
                new Comic { Name = "Revenge of the New Wave Freak ( damaged)", Issue = 68},
                new Comic { Name = "Black Monday", Issue = 74},
                new Comic { Name = "Tribal Tattoo Madness", Issue = 83},
                new Comic { Name = "The Death of an Object", Issue = 97},
            };
        }

        private static Dictionary<int, decimal> GetPrices()
        {
            return new Dictionary<int, decimal>{
            { 6, 3600M }, { 19, 500M }, { 36, 650M }, { 57, 13525M },
            { 68, 250M }, { 74, 75M }, { 83, 25.75M }, { 97, 35.25M },
            };
        }

        private void LinqMakesQueriesEasy()
        {
            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            var result = from v in values
                         where v < 37
                         orderby v
                         select v;

            CurrentQueryResults.Clear();
            foreach (int i in result)
            {
                CurrentQueryResults.Add(
                    new { Title = i.ToString(), ImagePath = "Assets/purple_250x250.jpg", });
            }
        }

        private void ExpensiveComics(){
            IEnumerable<Comic> comics = BuildCatalog();
            Dictionary<int, decimal> values = GetPrices();

            var mostExpensive= from comic in comics
                                where values[comic.Issue] > 500
                                orderby values[comic.Issue] descending
                                select comic;

            CurrentQueryResults.Clear();
            foreach (Comic comic in mostExpensive)
	        {
                CurrentQueryResults.Add(
                    new {Title = string.Format("{0} is worth {1:c}", comic.Name, values[comic.Issue]), ImagePath = "Assets/purple_250x250.jpg",});
	        }

        }



    }
}
