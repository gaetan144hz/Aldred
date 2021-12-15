using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour
{
    public void gameOver()
    {
        SceneManager.LoadScene(2); //Settings
    }
}
