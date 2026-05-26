using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rinha.Configuration
{
    public class FraudConstants
    {
        public const float MaxAmount = 10_000f;
        public const float MaxInstallments = 12f;
        public const float AmountVsAvgRatio = 10f;
        public const float MaxMinutes = 1_440f;
        public const float MaxKm = 1_000f;
        public const float MaxTxCount24h = 20f;
        public const float MaxMerchantAvgAmount = 10_000f;
        public static readonly Dictionary<string, float> MccRisk = new()
        {
            ["5411"] = 0.15f,
            ["5812"] = 0.30f,
            ["5912"] = 0.20f,
            ["5944"] = 0.45f,
            ["7801"] = 0.80f,
            ["7802"] = 0.75f,
            ["7995"] = 0.85f,
            ["4511"] = 0.35f,
            ["5311"] = 0.25f,
            ["5999"] = 0.50f,
        };

        public const float MccRiskDefault = 0.5f;
        public const float FraudThreshold = 0.6f;
        public const int KnnK = 5;
    }
}