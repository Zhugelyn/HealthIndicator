using UnityEngine;
using UnityEngine.UI;

public class HealthViewBarSmooth : HealthView
{
    [SerializeField] private Slider _bar;
    [SerializeField] private int _smoothingSpeed = 20;

    private int _currentValue;

    private void Awake()
    {
        Init();
        _bar.maxValue = CharacterCharacteristics.MaxHealth;
        _bar.value = CharacterCharacteristics.MaxHealth;
        _currentValue = CharacterCharacteristics.MaxHealth;
    }

    private void Update()
    {
        ChangeHealth(_currentValue);
    }

    private void OnEnable()
    {
        Health.HealthChanged += SetValue;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= SetValue;
    }

    private void ChangeHealth(int count)
    {
        _bar.value = Mathf.MoveTowards(_bar.value, count, Time.deltaTime * _smoothingSpeed);
    }

    private void SetValue(int count)
    {
        _currentValue = count;
    }
}
