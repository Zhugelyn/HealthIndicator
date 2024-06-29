using System;

public class Health
{
    public event Action<int> HealthChanged;
    public event Action Die;

    public Health(int amount)
    {
        Count = amount;
        MaxHealth = amount;
    }

    private int Count { get; set; }
    private int MaxHealth { get; set; }

    public void TakeDamage(int damage)
    {
        if (Count < 0)
            return;

        Count -= damage;
        HealthChanged?.Invoke(Count);

        if (Count <= 0)
            Die?.Invoke();
    }

    public void Restore(int recovery)
    {
        if (recovery < 0)
            return;

        Count = Math.Clamp(recovery + Count, Count, MaxHealth);
        HealthChanged?.Invoke(Count);
    }

    public int GetAmountHealth()
    {
        return Count;
    }
}
