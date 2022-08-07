using UnityEngine;

public class SequenceComposite : IAbility
{
    private IAbility[] children;

    public SequenceComposite(IAbility[] children)
    {
        this.children = children;
    }

    public void Use(GameObject currentGameObject)
    {
        foreach (var child in children)
            child.Use(currentGameObject);
    }
}

public class RageAbility : IAbility
{
    public void Use(GameObject currentGameObject) => Debug.Log("I'm always angry");
}

public class HealAbility : IAbility
{
    public void Use(GameObject currentGameObject) => Debug.Log("Here eat this!");
}

public class ShootAbility : IAbility
{
    public void Use(GameObject currentGameObject) => Debug.Log("Launch Fireball");
}
