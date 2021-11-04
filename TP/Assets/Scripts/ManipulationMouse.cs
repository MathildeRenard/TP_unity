using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulationMouse : MonoBehaviour
{
    
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Mettre un message lorsque l'on clique sur le bouton gauche de la souris
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Clic bouton gauche");
        }
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
      
        
        transform.Translate(h, v, 0);
      
    

    }

    }