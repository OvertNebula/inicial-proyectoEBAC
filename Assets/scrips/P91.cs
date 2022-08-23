using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P91 : MonoBehaviour
{
    int[] Arre11 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int[] Arre12 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    // Start is called before the first frame update
    void Start()    
    {
        for (int i = 0, j = 0, x; i < 0; i++) //j++) 
        {
            Random.Range (i,j);
            j = 2;
            x = i + j;
            Debug.Log(x);

        }

        //for (int i = 0; i < Arre1.Length; i++)
        //{
        //    foreach (int valor1 in Arre1)
        //    {
        //        
        //    }
        //    for (int e = 0; e < Arre1.Length; e++)
        //    {
        //        foreach(int valor2 in Arre1)
        //        {
        //            
        //        }
        //        for (int x = 0; x < Arre1.Length;)
        //        {
        //            x = Random.Range(i, e);
        //            Debug.Log(Arre1[x]);
        //        }
        //    }
        //}
        string[] Arre2 = new string[12] { "Enero ", "Febrero ", "Marzo ", "Abril ", "Mayo ", "Junio ", "Julio ", "Agosto ", "Septiembre ", "Octubre ", "Noviembre ", "Discembre" };
        for(int Mes =0;Mes<Arre2.Length; Mes++)
        {
            Debug.Log(Arre2[Mes]);
        }

        int Arre3;
        int[] Arre31 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[][] Arre32 = new int[][]
        {
            new int []{1,2,3},
            new int []{4,5,6}
        };
        for (int i = 0; i < Arre31.Length; i++)
        {
            for (int x = 0; x < Arre32.Length; x++)
            {
                Arre3 = i + x;

                for (int y = 0; y < Arre32[x].Length; y++)
                {
                    Arre3 = (i + x)*(i + y);

                    Debug.Log(Arre3);
                }
            }
        }
        

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
