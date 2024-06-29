using UnityEngine;

public class CharacterCharacteristics : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private int _damage;
    [SerializeField] private int _heal;

    public int MaxHealth => _maxHealth;
    public int Damage => _damage;
    public int Heal => _heal;
}
