using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityHandler : MonoBehaviour
{
    [Header("Buttons")]
    [SerializeField] private Button _hit;
    [SerializeField] private Button _heal;

    [Header("HealthView")]
    [SerializeField] private List<HealthView> _healthViews;

    [Header("Stats")]
    [SerializeField] private CharacterCharacteristics _characterCharacteristics;

    private void OnEnable()
    {
        _hit.onClick.AddListener(Strike);
        _heal.onClick.AddListener(RestoreHealth);
    }

    private void OnDisable()
    {
        _hit.onClick.RemoveListener(Strike);
        _heal.onClick.RemoveListener(RestoreHealth);
    }

    private void Strike()
    {
        foreach (HealthView healthView in _healthViews)
            healthView.Health.TakeDamage(_characterCharacteristics.Damage);
    }

    private void RestoreHealth()
    {
        foreach (HealthView healthView in _healthViews)
            healthView.Health.Restore(_characterCharacteristics.Heal);
    }
}
