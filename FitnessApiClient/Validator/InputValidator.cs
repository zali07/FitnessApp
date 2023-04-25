using FitnessApiClient.Api;
using FluentValidation;

namespace FitnessApiClient.Validator
{
    public class InputValidator<T> : AbstractValidator<T>
    {
        public InputValidator()
        {
            if (typeof(T) == typeof(TicketTypes))
            {
                RuleFor(x => ((TicketTypes)(object)x).Name)
                    .NotEmpty()
                    .WithMessage("Please enter a name.");
                RuleFor(x => ((TicketTypes)(object)x).Price)
                    .GreaterThan(0)
                    .WithMessage("Price must be greater than 0.");
                RuleFor(x => ((TicketTypes)(object)x).ValidityDays)
                    .GreaterThan(0)
                    .WithMessage("Validity days must be greater than 0.");
                RuleFor(x => ((TicketTypes)(object)x).ValidityEntries)
                    .GreaterThan(0)
                    .WithMessage("Validity entries must be greater than 0.");
                RuleFor(x => ((TicketTypes)(object)x).ArenaId)
                    .GreaterThan(0)
                    .WithMessage("ArenaId must be greater than 0.");
                RuleFor(x => ((TicketTypes)(object)x).StartHour)
                    .GreaterThanOrEqualTo(0)
                    .LessThanOrEqualTo(24)
                    .WithMessage("Start hour must be greater than or equal to 0.");
                RuleFor(x => ((TicketTypes)(object)x).EndHour)
                    .GreaterThanOrEqualTo(0)
                    .LessThanOrEqualTo(24)
                    .WithMessage("End hour must be less than or equal to 24.");
                RuleFor(x => ((TicketTypes)(object)x).EntriesPerDay)
                    .GreaterThan(0)
                    .WithMessage("Entries per day must be greater than 0.");
            }
        }
    }
}
