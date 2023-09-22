using UnityEngine;
using UnityEngine.Events;
public class Health : MonoBehaviour
{
    [SerializeField] private GameObject gameOverWindowPrefab;
    [SerializeField] private Transform canvasTransform;
    [SerializeField] private HealthData data;

    private void Start()
    {
        data.Current = data.MaxHealth;
    }

    public void Damage(int amount)
    {
        data.Current -= amount;
        data.OnChange.Invoke();
        if (data.Current <= 0)
        {
            Instantiate(gameOverWindowPrefab, canvasTransform);
            Time.timeScale = 0;
        }
    }
}
