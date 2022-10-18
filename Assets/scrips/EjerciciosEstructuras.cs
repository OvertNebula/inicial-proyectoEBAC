using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    public List<int> p12MiFuncion3 = new List<int>();
    public List<int> p12MiFuncion2 = new List<int>();
    //public List<int> p12MiFuncion(int tamaño, int rangoInferior, int rangoSuperior);
    // Start is called before the first frame update
    public void Start()
    {
        //p12MiFuncion1(10,0,20);
        //ist<int> RegresoDep12MiFuncion1 = p12MiFuncion1;
        //Debug.Log("MiFuncion1 " + RegresoDep12MiFuncion1);

        p12MiFuncion2.Sort();
        p12MiFuncion2.Add(9);
        p12MiFuncion2.Add(0);
        p12MiFuncion2.Add(6);
        p12MiFuncion2.Add(8);
        p12MiFuncion2.Add(1);
        p12MiFuncion2.Add(4);
        p12MiFuncion2.Add(2);
        foreach (int Fun2 in p12MiFuncion2)
        {
            Debug.Log("MiFuncion2 " + Fun2);
        }

        p12MiFuncion3.Add(1);
        p12MiFuncion3.Add(1);
        p12MiFuncion3.Add(2);
        p12MiFuncion3.Add(2);
        p12MiFuncion3.Add(3);
        p12MiFuncion3.Add(3);
        p12MiFuncion3.Add(4);
        p12MiFuncion3.Add(4);
        
    }

    // Update is called once per frame
    //public List<int> p12MiFuncion1 (int tamaño, int rangoInferior, int rangoSuperior)
    //{
    //    tamaño = (Random.Range(rangoInferior, rangoSuperior));
    //    Debug.Log("MiFuncion1 " + tamaño);
    //
    //    return p12MiFuncion1;
    //}
    public void MiFuncion2()
    {
        foreach (int Fun2 in p12MiFuncion2)
        {
            Debug.Log("MiFuncion2 " + Fun2);
        }

    }

    public void MiFuncion3()
    {
        foreach (int Fun3 in p12MiFuncion3)
        {

        }
    }



}
