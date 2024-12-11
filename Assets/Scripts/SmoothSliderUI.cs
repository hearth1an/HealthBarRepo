using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SmoothSliderUI : SliderHandler
{  
    private float _delay = 1;

    public override void ChangeValue(float value)
    {
        EnableCoroutine(value);
    }

    private void EnableCoroutine(float value)
    {
        StartCoroutine(ChangeValuesmoothly(value));
    }

    private IEnumerator ChangeValuesmoothly(float value)
    {
        float elapsedTime = 0;

        while (elapsedTime < _delay)
        {
            elapsedTime += Time.deltaTime;

            Slider.value = Mathf.MoveTowards(Slider.value, value, elapsedTime / _delay);

            yield return null;
        }
    }
}
