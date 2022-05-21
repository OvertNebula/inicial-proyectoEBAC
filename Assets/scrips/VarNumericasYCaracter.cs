using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarNumericasYCaracter : MonoBehaviour
{
    public GameObject varbleEntera;

    int ElCubo = 0;


    int p8int = 0;
    uint p8unit = 0;
    float p8float = 0;


    // Start is called before the first frame update
    void Start()
    {
        var meshRendered = varbleEntera.GetComponent<MeshRenderer>().material;

        p8unit = (uint)p8int;
        Debug.Log("casteo explisito:" + p8unit);

        int a, b;
        a = 1;
        b = 10;
        ElCubo = Random.Range(a, b);
        if (ElCubo %2 == 0)
        {
            meshRendered.color = Color.black;
            Debug.Log("el cubo" + ElCubo + " es par");
        }
        else
        {
            meshRendered.color = Color.white;
            Debug.Log("el cubo" + ElCubo + " es non");
        }

        


    }

    // Update is called once per frame
    void Update()
    {
        p8int *= 1;
        Debug.Log("int en update"+p8int);
    }
    private void FixedUpdate()
    {
        p8float *= 1;
        Debug.Log("float en fixedUpdate" +p8float);
    }
}
