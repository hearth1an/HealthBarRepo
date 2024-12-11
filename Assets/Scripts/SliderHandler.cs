using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public abstract class SliderHandler : MonoBehaviour
{
    [SerializeField] private HealthComponent _healthComponent;

    public Slider Slider { get; private set; }

    protected virtual void Awake()
    {
        Slider = GetComponent<Slider>();

        Slider.maxValue = _healthComponent.MaxHealth;
        Slider.minValue = _healthComponent.MinHealth;
        Slider.value = _healthComponent.MaxHealth;

        _healthComponent.ValueChanged += ChangeValue;
    }

    protected virtual void OnDestroy()
    {
        _healthComponent.ValueChanged -= ChangeValue;
    }

    public abstract void ChangeValue(float value);    
}
