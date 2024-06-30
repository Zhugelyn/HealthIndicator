using UnityEngine;
using UnityEngine.UI;

public class HealthViewBar : HealthView
{
    [SerializeField] private Slider _bar;

    private void Awake()
    {
        Init();
        _bar.maxValue = CharacterCharacteristics.MaxHealth;
        _bar.value = CharacterCharacteristics.MaxHealth;
    }

    private void OnEnable()
    {
        Health.Changed += SetValue;
    }

    private void OnDisable()
    {
        Health.Changed -= SetValue;
    }

    private void SetValue(int count)
    {
        _bar.value = count;
    }
}
