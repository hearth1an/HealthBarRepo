using UnityEngine;
using System;

public class HealthComponent : MonoBehaviour
{
    public event Action<float> ValueChanged;
    public float MaxHealth { get; private set; } = 100;
    public float MinHealth { get; private set; } = 0;
    public float Health { get; private set; }

    private void Awake()
    {
        Health = MaxHealth;
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;

        Health = Mathf.Clamp(Health, MinHealth, MaxHealth);
        ValueChanged?.Invoke(Health);
    }

    public void Heal(float heal)
    {
        Health += heal;

        Health = Mathf.Clamp(Health, MinHealth, MaxHealth);
        ValueChanged?.Invoke(Health);
    }
}
