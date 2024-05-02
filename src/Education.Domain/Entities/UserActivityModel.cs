﻿using Education.Domain.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Domain.Entities
{
    public class UserActivityModel
    {
        public Guid Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public double WatchedVideosByMinute { get; set; }
        public Guid UserId { get; set; }
        public virtual UserModel User { get; set; }
    }
}
