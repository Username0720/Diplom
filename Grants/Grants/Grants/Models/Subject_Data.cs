using System;
using System.Collections.Generic;
using System.Text;

namespace Grants.Models
{
    class Subject_Data
    {
        public int id { get; set; }
        public virtual Data Data { get; set; }
        public virtual User User { get; set; }
    }
}
