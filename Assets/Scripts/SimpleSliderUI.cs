using UnityEngine.UI;

public class SimpleSliderUI : SliderHandler
{     
    public override void ChangeValue(float value)
    {
        Slider.value = value;
    }
}
