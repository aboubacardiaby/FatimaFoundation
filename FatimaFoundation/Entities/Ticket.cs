﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FatimaFoundation.Entities
{
    public class Ticket: BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DonationDate { get; set; }
        public string PayPalReference { get; set; }
    }
}