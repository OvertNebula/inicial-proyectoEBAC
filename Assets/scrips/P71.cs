using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P71 : MonoBehaviour
{
    public GameObject objeToP71;

    bool variable1;
    bool variable2;
    int verdadero = 1;
    int falso = 0;
    // Start is called before the first frame update
    void Start()
    {
        var meshRenderedMaterial = objeToP71.GetComponent<MeshRenderer>().material;
        variable1 = true;
        variable2 = false;
        //Random.Range(variable1, variable2);
        Random.Range(verdadero, falso);
        if (verdadero >= 1)
        {
            meshRenderedMaterial.color = Color.white;
            Debug.Log("P71 verdadero");
        }
        else if (falso <= 0)
        {
            meshRenderedMaterial.color = Color.black;
            Debug.Log("P71 falso");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
