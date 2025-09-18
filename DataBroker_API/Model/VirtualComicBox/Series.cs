namespace DataBroker_API.Model.VirtualComicBox
{
    public class Series
    {
        public int Series_RefID { get; set; }

        public string Name { get; set; }

        public int YearBegan { get; set; }

        public int YearEnded { get; set; }

        public int IssueCounr { get; set; }

        public bool InPublication { get; set; }
    }
}
