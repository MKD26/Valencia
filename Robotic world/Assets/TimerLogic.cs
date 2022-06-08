using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLogic : MonoBehaviour
{
    public RectTransform timerLeiste;
    public Text timerText;
    public float gesamtZeit = 10;
    private float restZeit;
    private float timerLeisteStand;
    private float timerLeisteStartBreite;
    

    // Start is called before the first frame update
    void Start()
    {
        timerLeisteStartBreite = timerLeiste.rect.width;
    }

    // Update is called once per frame
    void Update()
    {
        restZeit = gesamtZeit - Mathf.Round(Time.fixedTime);
        timerText.text = restZeit.ToString();
        timerLeisteStand = timerLeisteStartBreite*(restZeit/100);
        timerLeiste.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, timerLeisteStand);
        if (restZeit < 0){
            Debug.Log("Zeit ist abgelaufen");
        }
    }

    public void ResetTimer(){
        gesamtZeit = Time.fixedTime + gesamtZeit;
    }
}
