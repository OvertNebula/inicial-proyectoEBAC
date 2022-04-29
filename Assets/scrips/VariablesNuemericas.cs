using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNuemericas : MonoBehaviour
{
    //byte  [0 0 0 0 0 0 0 0]
    //short [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //int   [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //log   [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //
    //float [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]
    //double[0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0] [0 0 0 0 0 0 0 0]

    sbyte miByteConsigno = 0;
    byte miByte = 0;
    short mishortSinSigno = 0;
    int miTnt = 0;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSiSingno = 0;

    // Start is called before the first frame update
    void Start()
    {
        miByteConsigno = 25;
        miTnt = miByteConsigno;
        Debug.Log("el valor de miByteConSigno" + miByteConsigno);
        Debug.Log("el valor de miInt" + miTnt);
        miByte = 200;
        miIntSinSigno = miByte;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
