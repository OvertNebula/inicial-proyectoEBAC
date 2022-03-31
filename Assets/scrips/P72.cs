using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P72 : MonoBehaviour
{
    public GameObject objeToP72;

    bool variable1;
    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        var meshRenderedMaterial = objeToP72.GetComponent<MeshRenderer>().material;
        if (variable1)
        {
            meshRenderedMaterial.color = Color.white;
            Debug.Log("P72 verdadero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
