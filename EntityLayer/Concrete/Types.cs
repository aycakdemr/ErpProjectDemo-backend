using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Types
    {
        public int Id { get; set; }
        public String TypeName { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
