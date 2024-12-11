using TMPro;
using UnityEngine;

public class TextUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private HealthComponent _healthComponent;

    private void OnEnable()
    {          
        UpdateText(_healthComponent.Health);
        _healthComponent.ValueChanged += UpdateText;        
    }

    private void OnDestroy()
    {
        _healthComponent.ValueChanged -= UpdateText;
    }

    private void UpdateText(float value)
    {            
        _text.text = $"{value}/{_healthComponent.MaxHealth}";
    }
}
