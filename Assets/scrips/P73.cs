using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P73 : MonoBehaviour
{
    public GameObject objeToP73;

    public GameObject objeToP71;
    public GameObject objeToP72;
    public bool tuVariableBool73 = false;
    // Start is called before the first frame update
    void Update()
    {
        objeToP73 = this.gameObject;

        var meshRenderedMaterial = objeToP73.GetComponent<MeshRenderer>().material;

        if (objeToP71.GetComponent<P71>().tuVariableBool71 || objeToP72.GetComponent<P72>().tuVariableBool72)
        {
            tuVariableBool73 = false;
            meshRenderedMaterial.color = Color.white;
            Debug.Log("su coneccion es verdadera");
        }
        else if (objeToP71)
        {
            tuVariableBool73 = true;
            meshRenderedMaterial.color = Color.black;
            Debug.Log("su coneccion es falsa");
        }
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //if (objeToP71 == true)
    //    //{
    //    //
    //    //}
    //}
}
