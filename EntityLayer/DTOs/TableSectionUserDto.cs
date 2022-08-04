using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTOs
{
    public class TableSectionUserDto
    {
        public int TableId { get; set; }
        public String TableNumber { get; set; }
        public String NumberOfChair { get; set; }
        public String SectionName { get; set; }
        public String BranchName { get; set; }
        public String UserName { get; set; }
        public Boolean Status { get; set; }
    }
}
