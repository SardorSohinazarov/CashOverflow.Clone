// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------

using System.Data;
using CashOverflow.Clone.Models.Salary;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Clone.Broker.StorageBroker;

public partial class StorageBroker
{
    public DbSet<Salary> Salaries { get; set; }
}
