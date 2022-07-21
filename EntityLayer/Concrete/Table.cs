using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Table : IEntity
    {
        public int Id { get; set; }
        public String TableNumber { get; set; }
        public String NumberOfChair { get; set; }
        public int SectionId { get; set; }
        public int BranchId { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
    }
}
