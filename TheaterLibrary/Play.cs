using System;
using System.Collections.Generic;

namespace TheaterLibrary
{
    public class Play
    {
        public string Name { get; }
        public TheaterGenre Genre { get; }
        public List<DateTime> PremiereDate = new List<DateTime>();
    }
}
