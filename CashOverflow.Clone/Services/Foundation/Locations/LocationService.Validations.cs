using CashOverflow.Clone.Models.Locations.Exceptions;
using CashOverflow.Clone.Models.Locations;
using System;
using FluentAssertions;
using System.Data;

namespace CashOverflow.Clone.Services.Foundation.Locations
{
    public partial class LocationService
    {
        private static void ValidationLocationOnAdd(Location location)
        {
            ValidationLocationOnAdd(location);

            Validate(
                    (Rule: IsInvalid(location.Id), Parametr: nameof(location.Id)),
                    (Rule: IsInvalid(location.Name), Parametr: nameof(location.Name)),
                    (Rule: IsInvalid(location.CreatedDate), Parametr: nameof(location.CreatedDate)),
                    (Rule: IsInvalid(location.UpdatedDate), Parametr: nameof(location.UpdatedDate)));
        }



        private static void ValidateLocationNotNull(Location location)
        {
            if (location is null)
                throw new NullLocationException();
        }

        private static dynamic IsInvalid(Guid id) => new
        {
            Condition = id == Guid.Empty,
            Message = "Id is required"
        };

        private static dynamic IsInvalid(string text) => new
        {
            Condition = String.IsNullOrWhiteSpace(text),
            Message = "Text is required"
        };

        private static dynamic IsInvalid(DateTimeOffset date) => new
        {
            Condition = date == default,
            Message = "Text is required"
        };

        private static void Validate(params (dynamic Rule, string Parametr)[] validations)
        {
            var invalidLocationException = new InvalidLocationException();

            foreach ((dynamic rule, string parametr) in validations)
            {
                if (rule.Condition)
                {
                    invalidLocationException.UpsertDataList(
                        key: parametr,
                        value: rule.Message);
                }
            }

            invalidLocationException.ThrowIfContainsErrors();
        }
    }
}