using UnityEngine;
using UnityEngine.Events;
public class Health : MonoBehaviour
{
    [SerializeField] private int current = 1;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private GameObject gameOverWindowPrefab;
    [SerializeField] private Transform canvasTransform;
    [SerializeField] private UnityEvent onChange;

    public int Current => current;
    public int MaxHealth => maxHealth;

    private void Start()
    {
        current = maxHealth;
    }

    public void Damage(int amount)
    {
        current -= amount;
        onChange.Invoke();
        if (current <= 0)
        {
            Instantiate(gameOverWindowPrefab, canvasTransform);
            Time.timeScale = 0;
        }
    }
}
