using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
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
       
       if (transform.position.y <= -1) 
       {
           transform.position = new Vector3(-19 , 2 , 33);
       }
    }
}
