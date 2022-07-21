using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Section : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public String Name { get; set; }
        public int NumberOfTable { get; set; }
        public String BranchName { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
    }
}
