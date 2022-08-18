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
        int[] miArreglo = new int[5];
        miArreglo = new int[7];
        string[] diasSemana = new string[7] { " lunes", " martes", " miercoles", " jueves", " viernes", " sabado", " domingo" };
        diasSemana = new string[] { " jueves", " viernes", " sabado", " domingo", " lunes", " martes", " miercoles" };

        for (int i = 0; i < diasSemana.Length; i++)
        {
            miArreglo[i] = i + 1;
            Debug.Log(diasSemana[i]);
        }
        //multidimencional
        int[,] miMatriz = new int[3, 3] { {1,2,3 },{4,5,6 },{7,8,9 } };
        for (int j = 0; j < miMatriz.GetLength(0); j++)
        {
            for (int k = 0; k <= miMatriz.GetLength(1); k++)
            {
                miMatriz[j, k] += 1;
                Debug.Log(miMatriz[j,k]);
            }
        }
        //bidimencional, Jagged
        int[][] miArregoloJagged = new int[][]
        {
            new int[]{1,2,3},
            new int[]{4,5},
            new int[]{6,7,8,9}
        };
        miArregoloJagged[1] = new int[] { 10, 11, 12, 13 };

        Debug.Log(miArregoloJagged[0][1]);
        for (int x= 0; x<miArregoloJagged.Length; x++)
        {
            for (int y=0; y < miArregoloJagged[x].Length; y++)
            {
                Debug.Log(miArregoloJagged[x][y]);
            }
        }


        //for (int i = 0; i < 10; i++)
        //{
        //    Debug.Log(i);
        //}


        //for (int e = 10; e > 1; e--)
        //{
        //    Debug.Log(e);
        //}
        bool miBool = false;
        //while (contador < 10) ;
        //{
        //    contador++;
        //    Debug.Log("hola");
        //}
        while (miBool)
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
