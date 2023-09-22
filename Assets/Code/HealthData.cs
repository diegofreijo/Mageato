using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "HealthData", menuName = "Mageato/HealthData", order = 0)]
public class HealthData : ScriptableObject {
    public UnityEvent OnChange;
    public int Current = 1;
    public int MaxHealth = 100;

    // public int Current => current;
    // public int MaxHealth => maxHealth;

}
