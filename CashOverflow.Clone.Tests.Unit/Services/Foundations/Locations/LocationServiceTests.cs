// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by CashOverflow Team
// --------------------------------------------------------

using System;
using System.Linq.Expressions;
using CashOverflow.Clone.Broker.Loggings;
using CashOverflow.Clone.Broker.StorageBroker;
using CashOverflow.Clone.Models.Locations;
using CashOverflow.Clone.Services.Foundation.Locations;
using Moq;
using Tynamix.ObjectFiller;
using Xeptions;

namespace CashOverflow.Clone.Tests.Unit.Services.Foundations.Locations;

public partial class LocationServiceTests
{
    private readonly Mock<IStorageBroker> storageBrokerMock;
    private readonly Mock<ILoggingBroker> loggingBrokerMock;
    private readonly ILocationService locationService;

    public LocationServiceTests()
    {
        this.storageBrokerMock = new Mock<IStorageBroker>();
        this.loggingBrokerMock = new Mock<ILoggingBroker>();

        this.locationService = new LocationService(
            storageBroker: this.storageBrokerMock.Object,
            loggingBroker:loggingBrokerMock.Object);
    }

    private Filler<Location> CreateLocationFiller(DateTimeOffset dates)
    {
        var filler = new Filler<Location>();

        filler.Setup()
            .OnType<DateTimeOffset>().Use(dates);

        return filler;
    }

    private Expression<Func<Xeption,bool>> SameExceptionAs(Xeption expectedException)=>
        actualException => actualException.SameExceptionAs(expectedException);

    private DateTimeOffset GetRandomDatetimeOffset() =>
        new DateTimeRange(earliestDate: DateTime.UnixEpoch).GetValue();

    private Location CreateRandomLocation() =>
        CreateLocationFiller(dates: GetRandomDatetimeOffset()).Create();
}
