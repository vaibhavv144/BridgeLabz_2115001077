using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Services
{
    public class ResponseModel
    {
        public string email { get; set; } = "";
        public bool success { get; set; } = true;
        public string Message { get; set; } = "";


    }
}


