using UnityEngine;

public class ButtonDamage : ButtonHandler
{
    [SerializeField] private HealthComponent _healthComponent;

    private float _damage = 25;

    public override void ChangeValue()
    {
        _healthComponent.TakeDamage(_damage);
    }
}
