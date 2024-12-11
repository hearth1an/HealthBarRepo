using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class SliderHandler : MonoBehaviour
{
    [SerializeField] private HealthComponent _healthComponent;

    private Slider _slider;

    private float maxValue => _healthComponent.MaxHealth;
    private float minxValue => _healthComponent.MinHealth;

    private void Awake()
    {
        _slider = GetComponent<Slider>();

        _slider.maxValue = maxValue;
        _slider.minValue = minxValue;
        _slider.value = maxValue;

        _healthComponent.ValueChanged += ChangeValue;
    }

    private void OnDestroy()
    {
        _healthComponent.ValueChanged -= ChangeValue;
    }

    private void ChangeValue(float value)
    {
        _slider.value = value;
    }
}
