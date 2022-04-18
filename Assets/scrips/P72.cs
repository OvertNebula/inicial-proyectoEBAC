using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P72 : MonoBehaviour
{
    public GameObject objeToP72;

    public bool tuVariableBool72;
    // Start is called before the first frame update
    void Update()
    {
        objeToP72 = this.gameObject;

        tuVariableBool72 = true;
        var meshRenderedMaterial = objeToP72.GetComponent<MeshRenderer>().material;
        if (tuVariableBool72)
        {
            meshRenderedMaterial.color = Color.white;
            Debug.Log("P72 verdadero");
        }
    }
}
