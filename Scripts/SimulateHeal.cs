using UnityEngine;

public class SimulateHeal : ButtonHandler
{
    private float _heal = 25;

    public override void ChangeValue()
    {
        Heal(_heal);
    }
}
