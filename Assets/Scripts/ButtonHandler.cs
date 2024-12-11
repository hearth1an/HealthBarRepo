using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public abstract class ButtonHandler : MonoBehaviour
{    
    private Button _button;

    protected virtual void OnEnable()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeValue);
    }

    protected virtual void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeValue);
    }

    public abstract void ChangeValue();   
}
