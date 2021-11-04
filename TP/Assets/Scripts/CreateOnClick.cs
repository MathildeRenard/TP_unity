using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOnClick : MonoBehaviour
{
    public Transform objetAcopier;
    GameObject player = GameObject.Find("PlayerCapsule");
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //test du clic droit de la souris
        if (Input.GetButton("Fire2"))
        {
            Debug.Log("clic droit");
            //GameObject newObject = Instantiate(objetAcopier, player.transform.position, player.transform.rotation ) as GameObject;
            //changement de couleur de la copie en bleu

            //newObject.GetComponent<Renderer>().material.color = Color.blue;

        }

    }
}
