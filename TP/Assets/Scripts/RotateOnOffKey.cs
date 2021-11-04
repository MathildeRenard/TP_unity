using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnOffKey : MonoBehaviour
{
    public string key = "d";
    public float speed = 5.0f;
    private bool enable;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            if (enable == true)
            {
                enable = false;
            }
            else
            {
                enable = true;
            }


        }
        if (enable == true)
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime, 5);
        }
        else
        {
            print("Mouvement arrêté.");
        }
    }
}
