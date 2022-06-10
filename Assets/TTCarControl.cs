using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TTCarControl : MonoBehaviour
{
    public float speed;
    float velocidad;
    float timer;
    float speedinicio;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        speedinicio = speed;
    }

    // Update is called once per frame
    void Update()
    {
        velocidad = speedinicio * Time.deltaTime;

        if (Input.GetKey(KeyCode.W)){

            transform.Translate(velocidad, 0 , 0);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedinicio++;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speedinicio = speed;
        }

        if ()

        if (Input.GetKey(KeyCode.S)){
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

       if (Input.GetKeyDown(KeyCode.Space))
       {
           rotationSpeed -= 30;
           speed += 10;
       }

       if (Input.GetKeyUp(KeyCode.Space))
       {
           rotationSpeed += 30;
           speed -= 10;
       }
       
       if (transform.position.y <= -1) 
       {
           transform.position = new Vector3(-73.2f , 20.5f , 0.1f);
           transform.eulerAngles = new Vector3(0 , 90 , 0);
       }

       if (Input.GetKey(KeyCode.R))
       {
           transform.position = new Vector3(-73.2f , 20.5f , 0.1f);
           transform.eulerAngles = new Vector3(0 , 90 , 0);
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
