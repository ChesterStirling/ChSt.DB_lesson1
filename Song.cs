namespace ChSt.DataBases
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }

        public virtual Group Groups { get; set; }
    }
}
