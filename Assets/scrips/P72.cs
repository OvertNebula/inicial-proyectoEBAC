using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P72 : MonoBehaviour
{
    public GameObject objeToP72;

    public bool tuVariableBool72 = true;
    // Start is called before the first frame update
    void Update()
    {
        var meshRenderedMaterial = objeToP72.GetComponent<MeshRenderer>().material;
        if (tuVariableBool72)
        {
            tuVariableBool72 = true;
            meshRenderedMaterial.color = Color.white;
            Debug.Log("P72 verdadero");
        }
    }
}
