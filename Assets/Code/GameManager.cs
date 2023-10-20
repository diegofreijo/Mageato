using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private HealthData health;

    void Start()
    {
        // ScoreManager.Instance.HighScore
    }

    public void LevelFinished()
    {
        if(ScoreManager.Instance.HighScore < health.Current)
            ScoreManager.Instance.HighScore = health.Current;

        // Save(ScoreManager.Instance);
    }


}
