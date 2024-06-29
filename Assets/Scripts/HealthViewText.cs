using TMPro;
using UnityEngine;

public class HealthViewText : HealthView
{
    [SerializeField] private TMP_Text _text;

    private int _maxValue;

    private void Awake()
    {
         Init();
        _maxValue = CharacterCharacteristics.MaxHealth;
        _text.text = SetDisplayModel(_maxValue);
    }

    private void OnEnable()
    {
        Health.HealthChanged += SetValue;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= SetValue;
    }

    private void SetValue(int count)
    {
        _text.text = SetDisplayModel(count);
    }

    private string SetDisplayModel(int currentValue)
    {
        return $"{currentValue}/{_maxValue}";
    }
}
