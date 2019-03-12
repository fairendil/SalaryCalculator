using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Models
{
    public class Salesman: Employee
    {
        public List<Employee> Subordinates { get; set; }
    }
}
