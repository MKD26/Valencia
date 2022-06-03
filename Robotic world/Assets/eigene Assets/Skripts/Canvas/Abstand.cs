using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abstand : MonoBehaviour
{


public GameObject abfrage;
public GameObject panel;

public GameObject skripthost;
Spieleraktivierendeaktiviern skript;

void Start() {
skripthost = GameObject.Find("First Person Player/Spieleraktivierendeaktivieren");
skript = skripthost.GetComponent<Spieleraktivierendeaktiviern>();

}

private void OnTriggerEnter(Collider other) {
    panel.SetActive(true);
    
}


private void OnTriggerStay(Collider other) {
Debug.Log ("YES");
    if (Input.GetKeyDown(KeyCode.E)){
         abfrage.SetActive(true);
         skript.Spieleraus();
        
    }
}

private void OnTriggerExit(Collider other) {
    panel.SetActive(false);
    
}
}
