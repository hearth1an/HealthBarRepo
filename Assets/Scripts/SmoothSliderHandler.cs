using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Slider))]
public class SmoothSliderHandler : MonoBehaviour
{
    [SerializeField] private HealthComponent _healthComponent;

    private float _delay = 1;
    private Slider _slider => GetComponent<Slider>();

    private float maxValue => _healthComponent.MaxHealth;
    private float minxValue => _healthComponent.MinHealth;

    private void Awake()
    {   
        _slider.maxValue = maxValue;
        _slider.minValue = minxValue;
        _slider.value = maxValue;

        _healthComponent.ValueChanged += EnableCoroutine;
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
