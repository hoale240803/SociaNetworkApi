﻿using System;
using System.Collections.Generic;

namespace Social.sakila
{
    public partial class Payment
    {
        public short PaymentId { get; set; }
        public short CustomerId { get; set; }
        public byte StaffId { get; set; }
        public int? RentalId { get; set; }
        public decimal Amount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Rental Rental { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
