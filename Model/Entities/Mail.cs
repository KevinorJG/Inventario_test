using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Mail
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string[] File { get; set; }
    }
}
