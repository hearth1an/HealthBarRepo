using UnityEngine;

public class SimulateDamage : ButtonHandler
{
    private float _damage = 25;

    public override void ChangeValue()
    {
        TakeDamage(_damage);
    }
}
