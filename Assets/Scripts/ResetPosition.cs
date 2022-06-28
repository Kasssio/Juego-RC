using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision piso)
    {
        if (piso.gameObject.name == "piso")
        {
            transform.position = new Vector3(-73.76f, 18, -0.24f);
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        }
    }
}
