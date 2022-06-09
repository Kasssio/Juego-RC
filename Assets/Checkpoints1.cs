using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints1 : MonoBehaviour
{
    public GameObject CheckPoint1;
    //Objetivo: hacer que cuando el auto haga contacto con todos los checkpoints y pase por el primero se cuente una vuelta
    //extra: si el auto se cae que respawnee en el ultimo checkpoint por el que pasó
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
