using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnMouse : MonoBehaviour
{
    private Color colorBase = Color.red;
    public Color newColor = Color.blue;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void OnMouseOver()
    {
        GameObject cube = GameObject.Find("Cube");
        cube.GetComponent<Renderer>().material.color = newColor;
        print("entrer");
    }
    void OnMouseExit()
    {
        GameObject cube = GameObject.Find("Cube");
        cube.GetComponent<Renderer>().material.color = colorBase;
        Debug.Log("sortie");
    }
}
