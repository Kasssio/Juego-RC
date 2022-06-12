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
            transform.Translate(speed * Time.deltaTime , 0 , 0);

            transform.Translate(velocidad, 0 , 0);

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
            transform.Translate(-speed * Time.deltaTime , 0 , 0);
            transform.Translate(-velocidad, 0 , 0);
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
       
       if (transform.position.y <= -1) 
       {
           transform.position = new Vector3(-73.2f , 20.5f , 0.1f);
           transform.eulerAngles = new Vector3(0 , 90 , 0);
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
