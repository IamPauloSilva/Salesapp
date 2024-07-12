using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; // Data already seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Fashion");
            Department d3 = new Department(3, "Books");

            _context.Department.AddRange(d1, d2, d3);
            _context.SaveChanges(); 

            Seller s1 = new Seller(1, "Paulo", "Paulo@gmail.com", new DateTime(1998, 4, 21), 1000, d1);
            Seller s2 = new Seller(2, "Sofia", "Sofia@gmail.com", new DateTime(1998, 4, 21), 1200, d1);
            Seller s3 = new Seller(3, "Luis", "Luis@gmail.com", new DateTime(1998, 4, 21), 3000, d2);

            _context.Seller.AddRange(s1, s2, s3);
            _context.SaveChanges(); 

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2024, 7, 1), 1100, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2024, 8, 1), 12000, s2);

            _context.SalesRecord.AddRange(sr1, sr2);
            _context.SaveChanges(); 
        }
    }
}
