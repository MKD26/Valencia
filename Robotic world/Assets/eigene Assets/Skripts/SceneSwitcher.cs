using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
  public void playGame(string szenenName)
{
    SceneManager.LoadScene(szenenName);
}
}
