using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Section : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        public String Name { get; set; }
        public int NumberOfTable { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool Status { get; set; }
        public List<Table> Tables { get; set; }
    }
}
