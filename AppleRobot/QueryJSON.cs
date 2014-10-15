using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppleRobot
{
    class QueryJSON
    {
        public bool firstTime { get; set; }
        public string keyword{ get; set; }
        public string _flowExecutionKey { get; set; }
        public string p_ie { get; set; }




        public string GetBase64String() { 
            int st=this.keyword.IndexOf("base64,");
            return this.keyword.Substring(st);
        }
    }
}



