using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P91 : MonoBehaviour
{
    int[] Arre11 = new int[10];
    int[] Arre12 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int[] Arre13 = new int[10];
    // Start is called before the first frame update
    void Start()    
    {
        for (int i = 0; i < Arre11.Length ; i++) //j++) 
        {
            //int[] Arre13 = new int[Arre11.Length];
            Arre11[i] = Random.Range(0, Arre11.Length);
            Arre12[i] = Random.Range(0, Arre12.Length);
            Arre13[i] = Arre11[i] + Arre12[i];
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

        int[] Arre3 = new int[2];
        int[] Arre31 = { 1, 2, 3 };
        int[,] Arre32 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        {

        };
        for (int i = 0; i < Arre31.Length; i++)
        {
            for (int x = 0; x < Arre32.GetLength(0); x++)
            {
                for (int y = 0; y < Arre32.GetLength(1); y++)
                {

                    Arre3[x] += Arre32[x,y] * Arre31[y];
                    
                }
                Debug.Log("resultado" + Arre3[x]);
            }
        }

        //extra - ejecicio Lalo tiene 5 discos 'd' y tras revisarlos los mete al cajón x, pero cada que mete un disco da un mensaje de 'Hola' más el numero de veces que lo haya hecho y después apunta cuantos discos metió en el cajón x.
        //d = discos
        //x = discos en el cajon
        int[] disco = { 1, 2, 3, 4, 5,};
        int d = 5;
        int X = 0;
        for (int I = 0; I < d; I++)
        {
            Debug.Log("Hola" + (I + 1));
            X++;
            Debug.Log("Discos metidos: " + X);
        }
        for (int D = 0; D < disco.Length; D++)
        {
            Debug.Log("Hola 2" + disco[D]);
            X++;
            Debug.Log("Discos metidos 2: " + X);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
