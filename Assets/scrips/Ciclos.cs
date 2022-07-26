using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciclos : MonoBehaviour
{
    //for               => sabemos cuantas veces vamos a repetir el ciclo
    //while             => no sabemos cuantas veces vamos a repetir el ciclo
    //do while          => al menos una vez si se ejecutara
    //arreglos unidimencionales
    //          => [0,1,2,3,4]
    //arreglos multidimencionales
    //          =>[0,1,2]
    //          =>[3,4,5]
    //          =>[6,7,8]
    //foreach
    //          =>[0,1,2,3,4,5]
    //          =>[6,7]
    //          =>[8,9,10]

    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; 1 < 10; i++)
        {
            Debug.Log(i);
        }


        for (int i = 10; 1 > 1; i--)
        {
            Debug.Log(i);
        }
        bool miBool = false;
        //while (contador < 10) ;
        //{
        //    contador++;
        //    Debug.Log("hola");
        //}
        while (miBool) ;
        {
            contador++;
            Debug.Log("hola");
        }

        do
        {
            Debug.Log("hola desde el do while");
        } while (miBool);
    }

    // Update is called once per frame
    void Update()
    {
        //contador++;
        //Debug.Log(contador);
    }
}
