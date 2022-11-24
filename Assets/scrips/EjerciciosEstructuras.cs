using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    //practica
    int[] PracArray = { 1, 2 };
    public List<int> PracList = new List<int>();
    public HashSet<int> PracHashSet = new HashSet<int>();
    Stack<int> PracStack = new Stack<int>();




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

        foreach (int Fun3 in p11MiFuncion3)
        {
            Debug.Log("list-MiFuncion3 " + Fun3);
        }


        p11MiFuncion4.Push("A");
        p11MiFuncion4.Push("B");
        p11MiFuncion4.Push("C");
        p11MiFuncion4.Push("D");
        p11MiFuncion4.Push("E");
        p11MiFuncion4.Push("F");
        p11MiFuncion4.Push("G");

        //practicas
        PracList.Add(3);
        PracList.Add(4);

        PracHashSet.Add(5);
        PracHashSet.Add(6);

        PracStack.Push(7);
        PracStack.Push(8);
    }
    //Prueba

    // Update is called once per frame
    public List<int> p11MiFuncion1 (int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> tamañoDebuelto = new List<int>();

        for (int i =0; i< tamaño; i++)
        {
            tamañoDebuelto.Add(Random.Range(rangoInferior, rangoSuperior));
        }
    
        return tamañoDebuelto;
    }
    public void MiFuncion2()
    {
        foreach (int Fun2 in p11MiFuncion2)
        {
            Debug.Log("MiFuncion2 " + Fun2);
        }

    }

    public HashSet<int> MiFuncion3(List<string> Repetidos)
    {
        HashSet<int> NoRepetidos = new HashSet<int>();
        foreach (string elementos in Repetidos)
        {
            NoRepetidos.Add(int32.Parse(elementos));
        }
        Debug.Log("HashSet-MiFuncion3 " + NoRepetidos);
        return NoRepetidos;

    }



    public void MiFuncion4()
    {
        Queue<string> textosDelQueue = new Queue<string> ();

        int Stack = p11MiFuncion4.Count;
        for (int i = 0; i < Stack; i++)
        {
            Debug.Log ("MiFuncion4 Stack: " + p11MiFuncion4.Peek());
            textosDelQueue.Enqueue(p11MiFuncion4.Peek());
            p11MiFuncion4.Pop();
        }

        int Queue = textosDelQueue.Count;
        for (int i =0;i<Queue; i++)
        {
            Debug.Log("MiFuncion4 Queue: " + textosDelQueue.Peek());
            textosDelQueue.Dequeue();
        }
    }

    public void MiFuncion5()
    {

    }


}