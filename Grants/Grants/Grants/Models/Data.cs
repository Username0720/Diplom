using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Grants.Models
{
    public class Data_
    {
        [Key]
        public int id_d { get; set; }
        public string konkurs_name { get; set; }
        public string href { get; set; }
        public string organization { get; set; }
        public string location_ { get; set; }
    }
}
