﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.Online.BLL
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }

        public int SecondName { get; set; }
        //public int Age { get; set; }

        public DateTime Birth { get; set; }

        public string IIN { get; set; }

        public string Sex { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year  - Birth.Year; }

        }  
        public Account[] Accounts { get; set; }
        public string Password { get; set; }
    }
}
