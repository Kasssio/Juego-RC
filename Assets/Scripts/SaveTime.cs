using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTime : MonoBehaviour
{
    public Text Tiempito;
    // Start is called before the first frame update
    void Start()
    {
       Tiempito.text = PlayerPrefs.GetString("tiempo", "0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
