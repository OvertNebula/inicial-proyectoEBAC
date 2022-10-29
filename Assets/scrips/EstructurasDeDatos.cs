using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
    List<int> listaNuemeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<int> HashSetInts = new HashSet<int>();
    Queue<string> colaStrings = new Queue<string>();
    Stack<string> pilaStrings = new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();
    // Start is called before the first frame update
    void Start()
    {
        DemoDictionary("Esopeta");
        DemoDictionary("Espada");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DemoListas()
    {
        for (int i = 0; i < 20; i++)
        {
            listaNuemeros.Add(Random.Range(0, 20));
        }
        foreach (var numero in listaNuemeros)
        {
            Debug.Log(numero);
        }

         
        //listaNuemeros.Sort();
        //var listaOrdenada = listaNuemeros.OrderBy(p => p).ToList();            //Error no explicado
        //var listaConValoresGrandes = listaNuemeros.Where(p => p > 10).ToList();//Error no explicado
        //Debug.Log("lista base");
        //foreach (var numero in listaOrdenada)
        //{
        //    Debug.Log(numero);
        //}
        //Debug.Log("listas de numeros ordenada");
        //foreach(var numero in listaOrdenada)
        //{
        //
        //}





        //
        //listaNuemeros.Sort();
        //foreach (var numero in listaNuemeros)
        //{
        //    Debug.Log("2" + numero);
        //}
        //listaStrings.Add("Diego");
        //listaStrings.Add("Sofia");
        //listaStrings.Add("Daniel");
        //listaStrings.Add("Javier");
        //listaStrings.Add("Dieana");
        //foreach (var nombre in listaStrings)
        //{
        //    Debug.Log(nombre);
        //}
        //listaStrings.Remove("Javier");
        //listaStrings.RemoveAt(4);
        //foreach (var nombre in listaStrings)
        //{
        //    Debug.Log("2" + nombre);
        //}
    }
    public void DemoHashSet()
    {
        for (int i = 0; i < 20; i++)
        {
            HashSetInts.Add(i);
        }
        if (HashSetInts.Contains(5))
        {
            HashSetInts.Remove(5);
        }
        else
        {
            Debug.Log("El HashSet no Contiene este elemento");
        }
    }

    public void DemoQueue()//cola
    {
        ///first in - first Out => Fifo
        colaStrings.Enqueue("Proyectil 1");
        colaStrings.Enqueue("Proyectil 2");
        colaStrings.Enqueue("Proyectil 3");
        colaStrings.Enqueue("Proyectil 4");
        colaStrings.Enqueue("Proyectil 5");
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
    }
    public void DemoStack()//pila
    {
        ///first in - Last out => Filo
        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
    }
    public void DemoDictionary(string arma)
    {
        float temporal = 0;
        if (!poderArmas.ContainsKey("rifle"))
        {
            poderArmas.Add("rifle", 7.0f);
        }
        if (!poderArmas.ContainsKey("Pistola"))
        {
            poderArmas.Add("Pistola", 3.0f);
        }
        if (!poderArmas.ContainsKey("Escopeta"))
        {
            poderArmas.Add("Escopeta", 5.0f);
        }
        if (!poderArmas.ContainsKey("rifleFrancotirador"))
        {
            poderArmas.Add("rifleFrancotirador", 10.0f);
        }
        if (!poderArmas.ContainsKey("cuchillo"))
        {
            poderArmas.Add("cuchillo", 2.0f);
        }
        if (poderArmas.TryGetValue(arma, out temporal))
        {
            Debug.Log(temporal);
        }
        else
        {
            Debug.Log("Esa arma no existe");
        }
    }
}

//Ejemplo de lista(int y string)