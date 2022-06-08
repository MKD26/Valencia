using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

public Question []questions;
private static List<Question> unansweredQuestions;

private Question currentQuestion;

[SerializeField]
private Text factText;

[SerializeField]
private Text trueAnswerText;

[SerializeField]
private Text falseAnswerText;

[SerializeField]
private float timeBetweenQuestions = 1f;

[SerializeField]
 private Animator animator;


//Felix

public GameObject canvas;
public GameObject skripthost;
Spieleraktivierendeaktiviern skript;
//Vanessa
public GameObject panel;
public GameObject panell;
public int zahl = 0;

void Start ()
{
    skripthost = GameObject.Find("First Person Player/Spieleraktivierendeaktivieren");
    skript = skripthost.GetComponent<Spieleraktivierendeaktiviern>();

    if (unansweredQuestions == null || unansweredQuestions.Count == 0)
    {
        unansweredQuestions= questions.ToList<Question>();

    }

    SetCurrentQuestion();



}


void SetCurrentQuestion()
{
    int randomQuestionIndex = Random.Range (0, unansweredQuestions.Count);
    currentQuestion = unansweredQuestions[randomQuestionIndex];

    factText.text = currentQuestion.fact;

    if (currentQuestion.isTrue)
    {
        trueAnswerText.text = "CORRECT";
        falseAnswerText.text = "FALSE";

    }
    else{
        trueAnswerText.text = "WRONG";
        falseAnswerText.text = "CORRECT";
    }
}

IEnumerator TransitionToNextQuestion ()
{
     unansweredQuestions.Remove(currentQuestion);

    //Input von Felix
    if (unansweredQuestions.Count > 0)
    {
    SetCurrentQuestion();
    
    }
    else
    {   yield return new WaitForSeconds (timeBetweenQuestions);
        canvas.SetActive(false);
        //Vanessa
        if(zahl == 3)
        {   Debug.Log("ES KLAPPT");
            panel.SetActive(true);
            // skript.Spielerein();
        }        

        else if (zahl < 3)
        {
                panell.SetActive(true);
               // skript.Spielerein();
        }
        skript.Spielerein();

    }
    {

    }
     yield return new WaitForSeconds (timeBetweenQuestions);

     // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

}

public void UserSelectTrue ()
{   Debug.Log("SELECT TRUE");
    animator.SetTrigger("True");
    if (currentQuestion.isTrue)
    {   zahl = zahl+1;
        Debug.Log("CORRECT!1");
    }
    else 
    {
        Debug.Log("WRONG!1");
    }

    StartCoroutine (TransitionToNextQuestion());
}

public void UserSelectFalse ()
{   Debug.Log("SELECT FALSE");
    animator.SetTrigger("False");
    if (!currentQuestion.isTrue)
    {   zahl = zahl+1;
        Debug.Log("CORRECT!2");
    }
    else 
    {
        Debug.Log("WRONG!2");
    }
    StartCoroutine (TransitionToNextQuestion());
}

}






