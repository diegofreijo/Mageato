using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // private static ScoreManager instance = null;
    public static ScoreManager Instance { get; private set; }

    public int HighScore = 0;

    // Cosas internas
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Cosas externas
    void Start()
    {

    }
}
