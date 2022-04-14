using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P73 : MonoBehaviour
{
    public GameObject objeToP73;

    public GameObject objeToP71;
    // Start is called before the first frame update
    void Start()
    {
        var meshRenderedMaterial = objeToP73.GetComponent<MeshRenderer>().material;
        if (objeToP71 == true)
        {
            meshRenderedMaterial.color = Color.white;
            Debug.Log("su coneccion es verdadera");
        }
        else if (objeToP71)
        {
            meshRenderedMaterial.color = Color.black;
            Debug.Log("su coneccion es falsa");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if (objeToP71 == true)
        //{
        //
        //}
    }
}
