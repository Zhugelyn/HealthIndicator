using UnityEngine;

public class HealthView : MonoBehaviour
{
    [field: SerializeField] public CharacterCharacteristics CharacterCharacteristics { get; private set; }

    public Health Health { get; private set; }

    public virtual void Init()
    {
        Health = new Health(CharacterCharacteristics.MaxHealth);
    }
}
