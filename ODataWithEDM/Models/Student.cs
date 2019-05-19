using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataWithEDM.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}
