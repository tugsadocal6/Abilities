using UnityEngine;

public class AbilityRunner : MonoBehaviour {
    [SerializeField] IAbility currentAbility = 
        new SequenceComposite(
            new IAbility[] {
                new HealAbility(),
                new RageAbility(),
                new DelayedDecorator(
                    new RageAbility()
                )
            }
        );
        
    public void UseAbility() => currentAbility.Use(gameObject);
}