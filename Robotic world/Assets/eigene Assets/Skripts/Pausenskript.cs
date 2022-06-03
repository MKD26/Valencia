using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausenskript : MonoBehaviour
{
    public GameObject pause;
    public GameObject stop;
    public bool menuon;
    Spieleraktivierendeaktiviern Spieler_Skript;


    // Start is called before the first frame update
    void Start()
    {
        Spieler_Skript= stop.GetComponent<Spieleraktivierendeaktiviern>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
                Pausenmenu();

        }
        
    }

    void Pausenmenu (){

        if(menuon==false)  {

            pause.SetActive (true);
            Spieler_Skript.Spieleraus();
            menuon = true;

        }  
        
        else{
            pause.SetActive (false);
            Spieler_Skript.Spielerein();
            menuon = false;
        }

        

    }

   public void Spielverlassen ()
    {
        Application.Quit();
        Debug.Log ("Spiel verlassen");

    }
}

    