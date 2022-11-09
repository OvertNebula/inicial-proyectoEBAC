using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    public List<int> p11MiFuncion3 = new List<int>();
    public List<int> p11MiFuncion2 = new List<int>();
    Stack<string> p11MiFuncion4 = new Stack<string>();
    //public List<int> p12MiFuncion(int tama�o, int rangoInferior, int rangoSuperior);
    // Start is called before the first frame update
    public void Start()
    {

        List<int> RegresoDep12MiFuncion1 = p11MiFuncion1(10, 0, 20);
        //p12MiFuncion1(10, 0, 20);
        Debug.Log("MiFuncion1 " + RegresoDep12MiFuncion1);

        p11MiFuncion2.Add(9);
        p11MiFuncion2.Add(0);
        p11MiFuncion2.Add(6);
        p11MiFuncion2.Add(8);
        p11MiFuncion2.Add(1);
        p11MiFuncion2.Add(4);
        p11MiFuncion2.Add(2);
        p11MiFuncion2.Sort();
        p11MiFuncion2.Reverse();

        foreach (int Fun2 in p11MiFuncion2)
        {
            Debug.Log("MiFuncion2 " + Fun2);
        }

        p11MiFuncion3.Add(1);
        p11MiFuncion3.Add(1);
        p11MiFuncion3.Add(2);
        p11MiFuncion3.Add(2);
        p11MiFuncion3.Add(3);
        p11MiFuncion3.Add(3);
        p11MiFuncion3.Add(4);
        p11MiFuncion3.Add(4);


        p11MiFuncion4.Push("A");
        p11MiFuncion4.Push("B");
        p11MiFuncion4.Push("C");
        p11MiFuncion4.Push("D");
        p11MiFuncion4.Push("E");
        p11MiFuncion4.Push("F");
        p11MiFuncion4.Push("G");
    }
    //Prueba
    // Update is called once per frame
    public List<int> p11MiFuncion1 (int tamaño, int rangoInferior, int rangoSuperior)
    {
        tamaño = (Random.Range(rangoInferior, rangoSuperior));
        Debug.Log("MiFuncion1 " + tamaño);
    
        return p11MiFuncion1(10, 0, 20);
    }
    public void MiFuncion2()
    {
        foreach (int Fun2 in p11MiFuncion2)
        {
            Debug.Log("MiFuncion2 " + Fun2);
        }

    }

    //public HashSet<int> MiFuncion3(int p12MiFuncion3)
    //{
    //    Debug.Log("MiFuncion3" + MiFuncion3);
    //}



    public void MiFuncion4()
    {
        foreach (string Fun4 in p11MiFuncion4)
        {
            Debug.Log(p11MiFuncion4.Peek());
            p11MiFuncion4.Pop();
            Debug.Log(p11MiFuncion4.Peek());
            p11MiFuncion4.Pop();
            Debug.Log(p11MiFuncion4.Peek());
            p11MiFuncion4.Pop();
            Debug.Log(p11MiFuncion4.Peek());
            p11MiFuncion4.Pop();
            Debug.Log(p11MiFuncion4.Peek());
            p11MiFuncion4.Pop();
            Debug.Log(p11MiFuncion4.Peek());
            p11MiFuncion4.Pop();
            Debug.Log(p11MiFuncion4.Peek());
            p11MiFuncion4.Pop();
        }
    }



}