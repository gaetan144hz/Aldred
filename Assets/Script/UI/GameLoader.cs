using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLoader : MonoBehaviour
{
    public void LevelLoader()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
}
