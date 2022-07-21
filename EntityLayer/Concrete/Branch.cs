using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Branch : IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public bool status { get; set; }
       
    }
}
