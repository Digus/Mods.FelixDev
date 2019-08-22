﻿using FelixDev.StardewMods.Common.StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixDev.StardewMods.FeTK.Framework.Services
{
    /// <summary>
    /// Provides an API to interact with the content of a <see cref="MoneyMail"/> instance.
    /// </summary>
    public interface IMoneyMailContent : IMailContent
    {
        /// <summary>
        /// The monetary value attached to the mail.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The attached monetary value cannot be less than zero.</exception>
        int AttachedMoney { get; set; }

        /// <summary>
        /// The currency of the monetary value attached to the mail.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">The specified currency is invalid.</exception>
        Currency Currency { get; set; }
    }
}
