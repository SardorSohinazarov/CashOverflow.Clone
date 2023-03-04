// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------

using System;
using CashOverflow.Clone.Broker.StorageBroker;
using CashOverflow.Clone.Models.Locations;
using CashOverflow.Clone.Services.Foundation.Locations;
using Moq;
using Tynamix.ObjectFiller;

namespace CashOverflow.Clone.Tests.Unit.Services.Foundations.Locations;

public partial class LocationServiceTests
{
    private readonly Mock<IStorageBroker> storageBrokerMock;
    private readonly ILocationService locationService;

    public LocationServiceTests()
    {
        this.storageBrokerMock = new Mock<IStorageBroker>();
        this.locationService = new LocationService(
            storageBroker: this.storageBrokerMock.Object);
    }

    public Location CreateRandomLocation() =>
        CreateLocationFiller(dates: GetRandomDatetimeOffset()).Create();

    private Filler<Location> CreateLocationFiller(DateTimeOffset dates)
    {
        var filler = new Filler<Location>();

        filler.Setup()
            .OnType<DateTimeOffset>().Use(dates);

        return filler;
    }

    private DateTimeOffset GetRandomDatetimeOffset() =>
        new DateTimeRange(earliestDate: DateTime.UnixEpoch).GetValue();
}
