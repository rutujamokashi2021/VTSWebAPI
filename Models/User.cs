﻿using System;
using System.Collections.Generic;

#nullable disable

namespace VTSWebAPI.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Organization { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string Location { get; set; }
        public string PhotoPath { get; set; }
    }
}
