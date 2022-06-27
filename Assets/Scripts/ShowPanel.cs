using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanel : MonoBehaviour
{
    bool EstaPrendido = false;
    public GameObject Controls;
    // Start is called before the first frame update
    void Start()
    {
        Controls.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (EstaPrendido == false)
            {
            Controls.SetActive(true);
            EstaPrendido = true;
            }
            else
            {
            Controls.SetActive(false);
            EstaPrendido = false;
            }
        } 
    }
}
