namespace DataBroker_API.Model.VirtualComicBox
{
    public class Issue
    {
        public int Issue_RefID { get; set; }

        public int Number { get; set; }

        public DateTime PublicationKeyDate { get; set; }

        public double Price { get; set; }

        public int VariantID { get; set; }

        public string VariantName { get; set; }

        public int Barcode { get; set; }

        public DateTime OnSaleDate { get; set; }
    }
}
