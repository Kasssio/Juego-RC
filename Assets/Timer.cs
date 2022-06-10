using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText; 
    static float timer;
    float milliseconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        timer += Time.deltaTime;

        milliseconds = (timer * 1000) - (Mathf.FloorToInt(timer - (timer / 60))*1000) - ((timer/60)*1000);

        string time = string.Format("{0:0}:{1:00}:{2:000}", Mathf.FloorToInt(timer / 60), Mathf.FloorToInt(timer - (Mathf.FloorToInt(timer / 60)) * 60), milliseconds); 

        timerText.text = time;
    }
}
