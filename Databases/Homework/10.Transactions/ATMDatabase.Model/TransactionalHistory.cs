﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMDatabase.Model
{
    public class TransactionHistory
    {
        public int Id { get; set; }

        public int CardNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Ammount { get; set; }
    }
}
