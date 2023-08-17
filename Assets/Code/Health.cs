using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int current = 1;
    [SerializeField] private GameObject gameOverWindowPrefab;
    [SerializeField] private Transform canvasTransform;

    public void Damage(int amount)
    {
        current -= amount;
        if (current <= 0)
        {
            Instantiate(gameOverWindowPrefab, canvasTransform);
            Time.timeScale = 0;
        }
    }
}
