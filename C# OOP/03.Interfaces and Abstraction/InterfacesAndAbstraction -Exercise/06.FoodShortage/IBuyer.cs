﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public interface IBuyer
    {
        public int Food { get; set; }

        public void BuyFood();
    }
}
