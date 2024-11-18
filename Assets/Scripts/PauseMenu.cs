using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        paused = true;

    }//eee PauseGame

    public void ResumeGame(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        paused = false;

    }//end resumeGame

    public void QuitGame(){
        Application.Quit();
        Debug.Log($"GAME ENDING");
    }
}//end class
