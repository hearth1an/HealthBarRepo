using UnityEngine.UI;

public class SliderSimpleUI : SliderHandler
{     
    public override void ChangeValue(float value)
    {
        Slider.value = value;
    }
}
