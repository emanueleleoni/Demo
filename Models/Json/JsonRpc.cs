using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LK2.Models
{
    public class JsonRpc
    {
        public string jsonrpc { get; set; }
        public string id { get; set; }
        public string result { get; set; }
    }
}
