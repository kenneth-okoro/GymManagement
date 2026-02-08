using ErrorOr;
using GymManagement.Domain.Entities.Subscriptions;
using MediatR;

namespace GymManagement.Application.Features.Subscriptions.Queries.GetSubscription
{
    public record GetSubscriptionQuery(Guid SubscriptionId) : IRequest<ErrorOr<Subscription>>;
}
