using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

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
            if (_context.Departament.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecords.Any())
            {
                return; // BD ja foi populado
            }

            Departament d1 = new Departament(1, "Computador");
            Departament d2 = new Departament(2, "Eletronicos");
            Departament d3 = new Departament(3, "Moda");
            Departament d4 = new Departament(4, "Livros");

            Seller s1 = new Seller(1, "Gustavo", "Gu@gustavo.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria", "Maria@gustavo.com", new DateTime(1980, 5, 13), 2300.0, d2);
            Seller s3 = new Seller(3, "João", "João@gustavo.com", new DateTime(1978, 6, 23), 4300.0, d4);
            Seller s4 = new Seller(4, "Marta", "Marta@gustavo.com", new DateTime(1996, 7, 11), 1200.0, d2);
            Seller s5 = new Seller(5, "Ronaldo", "Ronaldo@gustavo.com", new DateTime(1979, 8, 31), 5500.0, d1);
            Seller s6 = new Seller(6, "Rita", "Rita@gustavo.com", new DateTime(1987, 4, 10), 3500.0, d3);


            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2017, 09, 25), 12000.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2016, 09, 25), 13000.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2015, 09, 25), 14000.0, SaleStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 25), 15000.0, SaleStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 25), 16000.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 25), 17000.0, SaleStatus.Billed, s3);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 25), 18000.0, SaleStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 25), 19000.0, SaleStatus.Billed, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 25), 20000.0, SaleStatus.Billed, s1);

            _context.Departament.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalesRecords.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10);

            _context.SaveChanges();

        }
    }
}
