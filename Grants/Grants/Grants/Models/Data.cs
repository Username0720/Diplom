using System;
using System.Collections.Generic;
using System.Text;

namespace Grants.Models
{
    public class Data
    {
        public int id_data { get; set; }
        public string ahref { get; set; }
        public string maintext { get; set; }
        public string text { get; set; }
        public string begin_date { get; set; }
        public string end_date { get; set; }
        public string begin_request_date { get; set; }
        public string end_request_date { get; set; }
        public string status { get; set; }
        public string location { get; set; }
    }
}
