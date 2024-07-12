namespace SalesWebMvc.Models
{
    public class SalesRecord
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Ammount { get; set; }
        public double BaseSalary { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double ammount, Seller seller)
        {
            Id = id;
            Date = date;
            Ammount = ammount;
            
            Seller = seller;
        }
    }
}
