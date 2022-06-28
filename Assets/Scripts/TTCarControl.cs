using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TTCarControl : MonoBehaviour
{
    public float currentCheckpoint;
    public float speed;
    float velocidad;
    float timer;
    float speedinicio;
    public float maxSpeed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentCheckpoint = 0;
        speedinicio = speed;
    }

    // Update is called once per frame
    void Update()
    {


        velocidad = speedinicio * Time.deltaTime;


       #region movimiento
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(0 , 0 , -speed * Time.deltaTime);

            transform.Translate(0, 0 , -velocidad);

            if (speed < maxSpeed)
            {
                speed += 0.05f;
            }
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            speed = speedinicio;
        }


        if (Input.GetKey(KeyCode.S)){
            transform.Translate(0 , 0 , speed * Time.deltaTime);
            transform.Translate(0, 0 , velocidad);
        }

        if (Input.GetKey(KeyCode.D))
       {
        transform.eulerAngles += new Vector3(0 , rotationSpeed * Time.deltaTime , 0);
       }
        
        if (Input.GetKey(KeyCode.A))
       {
        transform.eulerAngles -= new Vector3(0 , rotationSpeed * Time.deltaTime , 0);
       }

       #endregion


        if (Input.GetKeyDown(KeyCode.LeftShift))
       {
            rotationSpeed += 20;
            speed -= 5f;
       }

       if (Input.GetKeyUp(KeyCode.LeftShift))
       {
           rotationSpeed -= 20;
           speed += 5;
       }

      if (Input.GetKey(KeyCode.Space))
        {
            maxSpeed += 10f;
        }

      if (Input.GetKeyUp(KeyCode.Space))
        {
            maxSpeed -= 10f;
        }

       if (Input.GetKey(KeyCode.R))
       {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

       if (Input.GetKey(KeyCode.E))
        {
            LoadScene();
            
        }
    }

    public void LoadScene()
    { 
        if (Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene("Menu");
            
        }
        
    }

}
