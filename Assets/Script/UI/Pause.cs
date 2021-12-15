using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenu;

    public void pauseResume(InputAction.CallbackContext ctx)
    {
        if (GameIsPaused)
        {
            onResume();
        }
        else
        {
            onPause();
        }
    }

    public void onResume()
    {
        //playerInput.player.spawn.Enable();
        //GetComponent<LadderSpawn>().enabled = true;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;              
        GameIsPaused = false;
    }

    public void onPause()
    {
        //playerInput.player.spawn.Disable();
        //GetComponent<LadderSpawn>().enabled = false;
        pauseMenu.SetActive(true);        
        Time.timeScale = 0f;        
        GameIsPaused = true;
    }
}
