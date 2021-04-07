using System;
namespace WebApplication2.Models
{
    public class User
    {
        public long Id { get; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }
        public DateTime  birth { get; set;  }
        public string address { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime dateSign { get; set; }

    }

}
