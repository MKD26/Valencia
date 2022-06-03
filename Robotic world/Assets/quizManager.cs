using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizManager : MonoBehaviour
{
    [Header("Question and Answer Area")]
    public string [] questionList;
    public string curQuestion;
    public string [] answerList;
    public string curAnswer;
    int itemCount;

    [Header("UI")]
    public Text questionTextDisp;
    public InputField answerArea;
    public Button submitBtn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curQuestion = questionList [itemCount];
        curAnswer = answerList [itemCount];

        questionTextDisp.text = curQuestion;
        
    }

    public void OnAnswering()
    {
        if(answerArea.text == curAnswer)
        {
            answerArea.text = "";
            itemCount ++;
        }
        else
        {
            answerArea.text = "";
        }
        if(itemCount == questionList.Length)
        {
            itemCount = 8;
        }
    }
}
