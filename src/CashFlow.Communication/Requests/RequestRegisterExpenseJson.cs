﻿using CashFlow.Communication.Enums;

namespace CashFlow.Communication.Requests;

public class RequestRegisterExpenseJson
{
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Data { get; set; }
    public decimal Amount { get; set; }
    public PaymentsType PaymentsType { get; set; }
}
