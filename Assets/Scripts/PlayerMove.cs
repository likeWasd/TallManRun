using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 0.1f;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * 0.1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * 0.1f;
        }
    }
}
