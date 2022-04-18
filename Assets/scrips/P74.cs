using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P74 : MonoBehaviour
{
    public GameObject objeToP74;
    public GameObject objeToP71;

    public bool tuVariableBool74;

    // Update is called once per frame
    void Update()
    {
        objeToP74 = this.gameObject;

        var meshRenderedMaterial = objeToP74.GetComponent<MeshRenderer>().material;

        if (objeToP71.GetComponent<P71>().tuVariableBool71 && objeToP74.GetComponent<P74>().tuVariableBool74)
        {
            tuVariableBool74 = false;
            meshRenderedMaterial.color = Color.white;
            Debug.Log("su coneccion es verdadera");
        }
        else if (objeToP74)
        {
            tuVariableBool74 = true;
            meshRenderedMaterial.color = Color.black;
            Debug.Log("su coneccion es falsa");
        }

    }
}
