using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AYUDA : MonoBehaviour
{
    public GameObject CUBO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(CUBO, this.gameObject.transform.position, this.gameObject.transform.localRotation);

        }
    }
}
