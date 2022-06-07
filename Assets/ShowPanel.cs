﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanel : MonoBehaviour
{
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
            Controls.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            Controls.SetActive(false);
        }

        
    }
}
