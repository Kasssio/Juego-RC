using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElFor : MonoBehaviour
{
    public GameObject HOLA;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject clon;
            clon = Instantiate(HOLA);
            Destroy(clon, 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
