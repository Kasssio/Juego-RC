using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints1 : MonoBehaviour
{
    public GameObject CheckPoint1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.name == "CheckPoint01") {
            
        }
    }
}
