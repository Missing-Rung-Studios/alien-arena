using Creatures.Api;
using Creatures.api.abilities.states;

namespace Creatures.api.abilities.basic
{
    public class BasicAttackEvent : AbilityEvent
    {
        public override AbilityExecutionResult ExecuteAbility(IPlayable playable)
        {
            return playable.BasicAttack(this);
        }

        public override AbilityIdentifier getId()
        {
            return AbilityIdentifier.BasicAttack;
        }

        public override void Subscribe(IStateNotifier notifier, CooldownState state)
        {
            notifier.Subscribe(state, this.getId(), notifier.GetBasicAttackCooldown());
        }
        
        public override void Unsubscribe(IStateNotifier notifier, CooldownState state)
        {
            notifier.Unsubscribe(state, this.getId());
        }
    }
}
