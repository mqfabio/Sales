using SalesWMvc.Data;
using SalesWMvc.Models;
using System.Collections.Generic;
using System.Linq;


namespace SalesWMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWMvcContext _context;

        public DepartmentService(SalesWMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList(); 
        }
    }
}


