using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringOperaciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string palabra1 = "elefante";
        string cambio1 = palabra1.Replace("f", "g");
        Debug.Log(cambio1);

        //char[] cambio1 = palabra1.ToCharArray();
        //cambio1[4] = 'g';
        //Debug.Log(cambio1);

        string palabra2 = "no creo";
        string cambio2 = palabra2.Replace("no","si");
        Debug.Log(cambio2);

        string palabra3;

        string palabra4 = "tengo mucho frio";
        string cambio4 = palabra4.Remove(6,5);
        Debug.Log(cambio4);
    }
}
