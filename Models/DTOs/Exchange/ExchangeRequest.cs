﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTOs.Exchange
{
    public class ExchangeRequest
    {
        public int UserId { get; set; }
        public double Amount { get; set; }
        public string? CurrencyCode { get; set; }
    }
}
