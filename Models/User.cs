﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AccessLevel { get; set; }

        public static class AccessLevels
        {
            public const int USER = 0;
            public const int ADMIN = 1;
        }
    }
}
