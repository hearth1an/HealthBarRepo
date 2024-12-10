using TMPro;
using UnityEngine;

public class TextHandler : HealthComponent
{
    [SerializeField] private TMP_Text _text;    
    
    private void OnEnable()
    {          
        UpdateText(Health);
        ValueChanged += UpdateText;        
    }

    private void OnDestroy()
    {
        ValueChanged -= UpdateText;
    }

    private void UpdateText(float value)
    {            
        _text.text = $"{value}/{MaxHealth}";
    }
}
