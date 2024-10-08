using Creatures.Api;

namespace Creatures.api.abilities.states
{
    /**
     * ReadyState indicates the ability is ready to be used.
     */
    public class ReadyState : IAbilityState
    {
        public void Enter()
        {
            // No-op
        }

        public void Exit()
        {
            // No-op
        }

        public AbilityExecutionResult Execute(IPlayable playable, AbilityEvent abilityEvent)
        {
            abilityEvent.SetState(new CooldownState(playable, abilityEvent));
            playable.triggerGlobalCooldown(abilityEvent);
            return abilityEvent.ExecuteAbility(playable);
        }
    }
}
