using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User_DTO
    {
        public string userName { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public string nickName { get; set; }
        public bool sex { get; set; }
        public DateTime birthDay { get; set; }
        public byte[] avatar { get; set; }   
        public int Age { get; set; }
    }
}
