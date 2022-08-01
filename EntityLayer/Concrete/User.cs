using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Mail { get; set; }
        public String PhoneNumber { get; set; }
        public bool Status { get; set; }
        public List<Section> Sections { get; set; }
        public List<Table> Tables { get; set; }
    }
}
