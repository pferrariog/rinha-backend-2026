using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rinha.Dtos;

public record FraudScoreRequest(
    string Id,
    TransactionInfo Transaction,
    CustomerInfo Customer,
    MerchantInfo Merchant,
    TerminalInfo Terminal,
    LastTransactionInfo? LastTransaction
);

public record TransactionInfo(
    decimal Amount,
    int Installments,
    DateTime RequestedAt
);

public record CustomerInfo(
    decimal AvgAmount,
    int TxCount24h,
    List<string> KnownMerchants
);

public record MerchantInfo(string Id, string Mcc, decimal AvgAmount);

public record TerminalInfo(bool IsOnline, bool CardPresent, double KmFromHome);

public record LastTransactionInfo(DateTime Timestamp, double KmFromCurrent);

