using Microsoft.CodeAnalysis.CSharp.Syntax;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingServices
    {
        private SalesWebMvcContext _context;
        
        public SeedingServices(SalesWebMvcContext context)
        {
            _context = context;

        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Eletronics");
            Department d2 = new Department(2, "Fashion");
            Department d3 = new Department(3, "Books");
            Department d4 = new Department(4, "Music");
            Department d5 = new Department(5, "Games");

            Seller s1 = new Seller(1, "Nelson Dias", "nelson@gmail.com", new DateTime(1985, 5, 21), 1000f, d1);
            Seller s2 = new Seller(2, "Clóvis Muralha", "clovis@gmail.com", new DateTime(1992, 7, 12), 1200f, d1);
            Seller s3 = new Seller(3, "Marcos Rogério", "Marcos@gmail.com", new DateTime(1982, 3, 24), 1853f, d1);
            Seller s4 = new Seller(4, "Peidaro Nakonbi", "peidaro@gmail.com", new DateTime(1979, 8, 4), 900f, d2);
            Seller s5 = new Seller(5, "Takaro Okunimi", "takaro@gmail.com", new DateTime(1973, 6, 12), 986f, d2);
            Seller s6 = new Seller(6, "Osmar Caco", "osmar@gmail.com", new DateTime(2000, 1, 8), 800f, d2);
            Seller s7 = new Seller(7, "Ava Gina", "ava@gmail.com", new DateTime(1969, 10, 11), 780f, d3);
            Seller s8 = new Seller(8, "Maria Bundasseca", "maria@gmail.com", new DateTime(1985, 11, 5), 697f, d3);
            Seller s9 = new Seller(9, "Belo Pinto", "belo@gmail.com", new DateTime(1994, 12, 25), 598f, d3);
            Seller s10 = new Seller(10, "Timelo Rego", "timelo@gmail.com", new DateTime(1999, 9, 19), 1200f, d4);
            Seller s11 = new Seller(11, "Paul Mole", "paul@gmail.com", new DateTime(1988, 8, 27), 996f, d4);
            Seller s12 = new Seller(12, "Alisa Meosako", "alisa@gmail.com", new DateTime(1993, 2, 1), 1800f, d4);
            Seller s13 = new Seller(13, "Caio Pinto", "caio@gmail.com", new DateTime(1978, 4, 29), 1200f, d5);
            Seller s14 = new Seller(14, "Miku Mero", "miku@gmail.com", new DateTime(1989, 5, 21), 1350f, d5);
            Seller s15 = new Seller(15, "Thomas Turbando", "thomas@gmail.com", new DateTime(1998, 5, 21), 650f, d5);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 11000.0f, s1, SaleStatus.Billed);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 4), 7000.0f, s1, SaleStatus.Billed);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 13), 4000.0f, s2, SaleStatus.Canceled);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 1), 8000.0f, s2, SaleStatus.Billed);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 21), 3000.0f, s3, SaleStatus.Billed);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 15), 2000.0f, s3, SaleStatus.Billed);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 28), 13000.0f, s4, SaleStatus.Billed);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 11), 4000.0f, s4, SaleStatus.Billed);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 09, 14), 11000.0f, s5, SaleStatus.Pending);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2018, 09, 7), 9000.0f, s5, SaleStatus.Billed);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2018, 09, 13), 6000.0f, s6, SaleStatus.Billed);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2018, 09, 25), 7000.0f, s6, SaleStatus.Pending);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2018, 09, 29), 10000.0f, s7, SaleStatus.Billed);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2018, 09, 4), 3000.0f, s7, SaleStatus.Billed);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2018, 09, 12), 4000.0f, s8, SaleStatus.Billed);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2018, 10, 5), 2000.0f, s8, SaleStatus.Billed);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2018, 10, 1), 12000.0f, s9, SaleStatus.Billed);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2018, 10, 24), 6000.0f, s9, SaleStatus.Billed);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2018, 10, 22), 8000.0f, s10, SaleStatus.Billed);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2018, 10, 15), 8000.0f, s10, SaleStatus.Billed);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2018, 10, 17), 9000.0f, s11, SaleStatus.Billed);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2018, 10, 24), 4000.0f, s11, SaleStatus.Billed);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2018, 10, 19), 11000.0f, s12, SaleStatus.Canceled);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2018, 10, 12), 8000.0f, s12, SaleStatus.Billed);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2018, 10, 31), 7000.0f, s13, SaleStatus.Billed);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2018, 10, 6), 5000.0f, s13, SaleStatus.Billed);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2018, 10, 13), 9000.0f, s14, SaleStatus.Pending);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2018, 10, 7), 4000.0f, s14, SaleStatus.Billed);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2018, 10, 23), 12000.0f, s15, SaleStatus.Billed);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2018, 10, 12), 5000.0f, s15, SaleStatus.Billed);

            _context.Department.AddRange(d1, d2, d3, d4, d5);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);

            _context.SaveChanges();
        }
    }
}
