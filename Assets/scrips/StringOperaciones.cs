using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringOperaciones : MonoBehaviour
{
    public GameObject ColorCubo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string var1 = "2";
        string var2 = "3";
        int result = int.Parse(var1) + int.Parse(var2);

        //E incluso puede ser:
        //int result = int.Parse("2") + int.Parse("3");

        Debug.Log(result);
        //E incluso puede ser:
        //Debug.Log(Int32.Parse("2") + Int32.Parse("3"));

        //Esto imprimiria: 5 //

        string palabra1 = "elefante";
        string cambio1 = palabra1.Replace("f", "g");
        Debug.Log(cambio1); 

        //char[] cambio1 = palabra1.ToCharArray();
        //cambio1[4] = 'g';
        //Debug.Log(cambio1);

        string palabra2 = "no creo";
        string cambio2 = palabra2.Replace("no", "si");
        Debug.Log(cambio2);

        var meshRendered = ColorCubo.GetComponent<MeshRenderer>().material;

        string var3 = "3";
        string var4 = "2";
        int resultado = int.Parse(var3) + int.Parse(var4);
        //resultado = int.Parse(var3, var4);
        //if (resultado % 2 == 0)
        //{
        //    meshRendered.color = Color.black;
        //    Debug.Log("el cubo" + resultado + " es par");
        //}
        //else
        //{
        //    meshRendered.color = Color.white;
        //    Debug.Log("el cubo" + resultado + " es non");
        //}

        //string palabra3 = "me trade";
        //string[] cambio3 = palabra3.Split('%');
        //Debug.Log(cambio3);


        string palabra4 = "tengo mucho frio";
        string cambio4 = palabra4.Remove(6,5);
        Debug.Log(cambio4);
    }
}
