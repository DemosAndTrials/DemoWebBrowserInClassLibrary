﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OAuth
{
     public class Config
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string InstanceUrl { get; set; }
    }
}