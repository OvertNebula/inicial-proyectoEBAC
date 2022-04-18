using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P75 : MonoBehaviour
{
    public GameObject objeToP75;
    public GameObject objeToP73;
    public GameObject objeToP74;

    public bool tuVariableBol75;

    // Update is called once per frame
    void Update()
    {
        objeToP75 = this.gameObject;

        var meshRenderedMaterial = objeToP75.GetComponent<MeshRenderer>().material;

        if ((objeToP73.GetComponent<P73>().tuVariableBool73 || objeToP74.GetComponent<P74>().tuVariableBool74) && objeToP73.GetComponent<P73>().tuVariableBool73)
        {
            meshRenderedMaterial.color = Color.white;
            Debug.Log("su coneccion es verdadera");
        }
        else
        {
            meshRenderedMaterial.color = Color.black;
            Debug.Log("su coneccion es falsa");
        }

    }
}
