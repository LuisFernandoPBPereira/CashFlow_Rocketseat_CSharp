﻿using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;

public class RegisterExpenseValidator : AbstractValidator<RequestRegisterExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Title).NotEmpty().WithMessage("The title is required");
        RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("The amount must be greater than zero");
        RuleFor(expense => expense.Data).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("The date can't be in the future");
        RuleFor(expense => expense.PaymentsType).IsInEnum().WithMessage("The payment type is not valid");
    }
}
