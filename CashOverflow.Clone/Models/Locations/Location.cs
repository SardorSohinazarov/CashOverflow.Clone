// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------

using System;

namespace CashOverflow.Clone.Models.Locations
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
