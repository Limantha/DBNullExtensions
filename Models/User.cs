﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBNullExtensions.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public DateTime DOB { get; set; }
    }
}