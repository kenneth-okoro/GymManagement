using ErrorOr;
using GymManagement.Domain.Entities.Subscriptions;
using MediatR;

namespace GymManagement.Application.Features.Subscriptions.Commands.CreateSubscription
{
    public record CreateSubscriptionCommand(
        string SubscriptionType,
        Guid AdminId) : IRequest<ErrorOr<Subscription>>;
}
