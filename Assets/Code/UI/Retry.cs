using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Parallax");
    }
}
