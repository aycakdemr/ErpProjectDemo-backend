using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ToDoList
    {
        public int Id { get; set; }
        public String Title{ get; set; }
        public String Detail{ get; set; }
        public DateTime Date{ get; set; }
        public bool Status{ get; set; }
    }
}
