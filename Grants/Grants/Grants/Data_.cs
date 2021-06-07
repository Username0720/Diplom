using System;
using System.Collections.Generic;
using System.Text;

namespace Grants
{
    public class Data_
    {
        public string konkurs_name { get; set; }
        public string href { get; set; }
        public string organization { get; set; }
        public string date_begin { get; set; }
        public string date_end { get; set; }
        public string date_ { get; set; }
        public string location_ { get; set; }

        public override bool Equals(object obj)
        {
            Data_ Data = obj as Data_;
            return konkurs_name == Data.konkurs_name;
        }
    }
}
