using SalesWMvc.Data;
using SalesWMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWMvc.Services
{
    public class SellerService
    {
        private readonly SalesWMvcContext _context; 

        public SellerService(SalesWMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        } 
        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First(); 
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
