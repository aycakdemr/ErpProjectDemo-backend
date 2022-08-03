using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Notification
    {
        public int Id { get; set; }
        public String Detail { get; set; }
        public int TypeId { get; set; }
        public Types Type { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool Status { get; set; }
    }
}
