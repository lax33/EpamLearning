using System.Collections.Generic;

namespace Linq.NET5CombiningSequencesIntoOne
{
    internal class Student
    {
        public string First { get; internal set; }
        public string Last { get; internal set; }
        public int ID { get; internal set; }
        public List<int> Scores { get; internal set; }
        public string Street { get; internal set; }
        public string City { get; internal set; }
    }
}