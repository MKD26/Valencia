using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausenMenu : MonoBehaviour
{    
    //Me
    Spieleraktivierendeaktiviern Spieler_Skript;
     public GameObject stop;
    //Me
        public static bool GameIsPaused = false;

        public GameObject pauseMenuUI;

//me
 void Start()
    {
        Spieler_Skript= stop.GetComponent<Spieleraktivierendeaktiviern>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            { 
                Resume();
            }
            else
             {
                    Pause();
            }

        }
    }



     public void Resume ()
    {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
            Spieler_Skript.Spielerein();

    }

    void Pause ()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Spieler_Skript.Spieleraus();
    }

    public void LoadMenu()
    {   
        Time.timeScale = 1f;
        SceneManager.LoadScene("Instructions");

    }

    public void QuitGame ()
    {

        Debug.Log("Quitting menu...");
        Application.Quit();
    }

}
