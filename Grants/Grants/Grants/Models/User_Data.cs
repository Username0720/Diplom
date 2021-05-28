using System;
using System.Collections.Generic;
using System.Text;

namespace Grants.Models
{
    class User_Data
    {
        public int id_user_data { get; set; }
        public virtual User User { get; set; }
        public virtual Data_ Data_ { get; set; }
    }
}
