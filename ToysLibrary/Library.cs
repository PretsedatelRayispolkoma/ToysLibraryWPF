using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysLibrary
{
    public class Toy
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public int Number { get; set; }

        public Toy(string ttle, string pblshr, int nmbr)
        {
            Title = ttle;
            Publisher = pblshr;
            Number = nmbr;
        }
    }

    public class Book : Toy
    {
        public string Author { get; set; }
        public bool Illustration { get; set;}

        public Book(string ttle, string athr, bool ilstr, string pblshr, int nmbr) : base (ttle, pblshr, nmbr)
        {
            Author = athr;
            Illustration = ilstr;
        }

    }

    public class Puzzle : Toy
    {
        public Puzzle(string ttle, string pblshr, int nmbr) : base(ttle, pblshr, nmbr)
        { }
    }

    public class TableToy : Toy
    {
        public string Description { get; set; }
        public int MaxPlayers { get; set; }

        public TableToy(string ttle, string pblshr, string dscrptn, int nmbr, int mxplyers) : base(ttle, pblshr, nmbr)
        {
            Description = dscrptn;
            MaxPlayers = mxplyers;
        }
    }
}
