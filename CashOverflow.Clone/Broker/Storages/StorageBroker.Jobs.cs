﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------

using CashOverflow.Clone.Models.Job;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Clone.Broker.StorageBroker;

public partial class StorageBroker
{
    public DbSet<Job> Jobs { get; set; }
}
