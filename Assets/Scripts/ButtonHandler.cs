using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class ButtonHandler : HealthComponent
{  
    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeValue);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeValue);
    }

    public abstract void ChangeValue();
   
}
