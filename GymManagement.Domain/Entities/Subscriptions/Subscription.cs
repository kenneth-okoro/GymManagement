using GymManagement.Contracts.Subscriptions;

namespace GymManagement.Domain.Entities.Subscriptions
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public string SubscriptionType { get; set; } = null!;
    }
}
