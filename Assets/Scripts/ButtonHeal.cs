using UnityEngine;

public class ButtonHeal : ButtonHandler
{
    [SerializeField] private HealthComponent _healthComponent;

    private float _heal = 25;

    public override void ChangeValue()
    {
        _healthComponent.Heal(_heal);
    }
}
