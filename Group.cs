using System.Collections.Generic;

namespace ChSt.DataBases
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Year { get; set; }

        public virtual ICollection<Song> Songs { get; set; }
    }
}
