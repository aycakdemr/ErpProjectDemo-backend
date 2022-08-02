using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs
{
    public class SectionDto
    {
        public int SectionId { get; set; }
        public int Number { get; set; }
        public String Name { get; set; }
        public int NumberOfTable { get; set; }
        public String BranchName{ get; set; }
        public String UserName { get; set; }
    }
}
