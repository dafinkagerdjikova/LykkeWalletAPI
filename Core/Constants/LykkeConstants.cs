﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Constants
{
    public static class LykkeConstants
    {
        public const string DefaultAssetSetting = "Default";

        public const int TotalLykkeAmount = 1250000000;

        public const int MinPwdLength = 6;
        public const int MaxPwdLength = 100;

        public const int DefaultRefundTimeoutDays = 30;

        public static readonly TimeSpan SessionLifetime = TimeSpan.FromDays(3);
        public static readonly TimeSpan SessionRefreshPeriod = TimeSpan.FromDays(1);

        #region Cache keys

        public const string LastAskBidForAssetOnPeriod = "__Asset_{0}_Last_ask{1}_{2}__";

        #endregion

        public static string GetLastAskForAssetOnPeriodKey(string assetPairId, string period, bool ask)
        {
            return string.Format(LastAskBidForAssetOnPeriod, assetPairId, ask, period);
        }
    }
}
