using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float currentCheckpoint;
    public float speed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentCheckpoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(speed * Time.deltaTime , 0 , 0);
        }

        if (Input.GetKey(KeyCode.S)){
            transform.Translate(-speed * Time.deltaTime , 0 , 0);
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
            speed -= 20f;
       }

       if (Input.GetKeyUp(KeyCode.LeftShift))
       {
           rotationSpeed -= 20;
           speed += 20;
       }

       if (Input.GetKeyDown(KeyCode.Space))
       {
           rotationSpeed -= 30;
           speed += 30;
       }

       if (Input.GetKeyUp(KeyCode.Space))
       {
           rotationSpeed += 30;
           speed -= 30;
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
