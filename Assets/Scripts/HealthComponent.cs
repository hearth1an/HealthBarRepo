using UnityEngine;
using TMPro;
using System;

public abstract class HealthComponent : MonoBehaviour
{
    public float MaxHealth { get; private set; } = 100;
    public float MinHealth { get; private set; } = 0;
    public float Health { get; private set; }

    public event Action<float> ValueChanged;

    private void Awake()
    {
        Health = MaxHealth;
    }

    private void ValidateHealth()
    {
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }

        if (Health < MinHealth)
        {
            Health = MinHealth;
        }
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