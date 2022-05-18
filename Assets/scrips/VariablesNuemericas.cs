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
    short mishort = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = 0;
    ulong miLongSiSingno = 0;

    // Start is called before the first frame update
    void Start()
    {
        miByteConsigno = 25;
        miInt = miByteConsigno;
        Debug.Log("el valor de miByteConSigno" + miByteConsigno);
        Debug.Log("el valor de miInt" + miInt);
        miByte = 200;
        miIntSinSigno = miByte;
        miIntSinSigno = (uint)miByteConsigno;
        Debug.Log("el valor de miInt es" + miIntSinSigno);

        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("el valor de miInt es:" + miInt);

        int a, b, c;
        a = 5;
        b = 10;
        c = a + b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        c = a / b;
        Debug.Log(c);
        float f;
        f = (a / b);
        Debug.Log(f);

        miInt = Random.Range (a, b);
        if (miInt % 2 == 0)
        {
            Debug.Log("el numero" + miInt + "es par");
        }
        else
        {
            Debug.Log("el numero" + miInt + "es non");
        }



    }

    // Update is called once per frame
    void Update()
    {
        mishort *= 3;
        Debug.Log(mishort);

        miLong += 2;         // esta y
        miLong = miLong + 2; // esta son lo mismo
        Debug.Log(miLong);
    }
}
