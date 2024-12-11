using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Slider))]
public class SmoothSliderHandler : MonoBehaviour
{
    [SerializeField] private HealthComponent _healthComponent;

    private float _delay = 1;

    private Slider _slider;

    private float MaxValue => _healthComponent.MaxHealth;
    private float MinValue => _healthComponent.MinHealth;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = MaxValue;
        _slider.minValue = MinValue;
        _slider.value = MaxValue;

        _healthComponent.ValueChanged += EnableCoroutine;
    }

    private void OnDestroy()
    {
        _healthComponent.ValueChanged -= EnableCoroutine;
    }

    private void EnableCoroutine(float value)
    {
        StartCoroutine(ChangeValuesmoothly(_healthComponent.Health));
    }

    private IEnumerator ChangeValuesmoothly(float value)
    {
        float elapsedTime = 0;

        while (elapsedTime < _delay)
        {
            elapsedTime += Time.deltaTime;

            _slider.value = Mathf.MoveTowards(_slider.value, value, elapsedTime / _delay);

            yield return null;
        }
    }
}
