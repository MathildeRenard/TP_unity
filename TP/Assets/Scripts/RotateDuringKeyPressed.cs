using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDuringKeyPressed : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime, 5);
            print("Mouvement effectué.");
        }
    }
}
