using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoints1 : MonoBehaviour
{

    //Objetivo: hacer que cuando el auto haga contacto con todos los checkpoints se cuente una vuelta
    //extra: si el auto se cae que respawnee en el ultimo checkpoint por el que pasó
    public Timer Tiempucho;
    public int currentCheckpoint;

    void Start()
    {
        currentCheckpoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnTriggerEnter(Collider NumCheck)
    {
        if (NumCheck.gameObject.name == "CheckPoint01" && currentCheckpoint == 0)
        {
            currentCheckpoint++;
        }

        if (NumCheck.gameObject.name == "CheckPoint02" && currentCheckpoint == 1)
        {
            currentCheckpoint++;
        }

        if (NumCheck.gameObject.name == "CheckPoint03" && currentCheckpoint == 2)
        {
            currentCheckpoint++;
        }

        if (NumCheck.gameObject.name == "CheckPoint01" && currentCheckpoint == 3)
        {
            Tiempucho.TimeSave();
            SceneManager.LoadScene("Tiempo");
        }

    }

}
