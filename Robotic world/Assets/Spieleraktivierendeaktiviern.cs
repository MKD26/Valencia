using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieleraktivierendeaktiviern : MonoBehaviour
{
   public Transform playerTransform;
   public Camera playerCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
// damit geht Maus an und man kann klicken
    public void Spieleraus()
{
    Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        playerTransform.GetComponent<PlayerMovement>().enabled = false;
        playerCam.GetComponent<mouselook>().enabled = false;
}
public void Spielerein ()
{
    Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        playerTransform.GetComponent<PlayerMovement>().enabled = true;
        playerCam.GetComponent<mouselook>().enabled = true;


}
}
