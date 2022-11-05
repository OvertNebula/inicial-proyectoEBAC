using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clases : MonoBehaviour
{
    /// <summary>
    /// campos
    /// </summary>
    public float campo1; // public: que o podra ser vista por otras clases
    private bool campo2; // private: solo esta clase podra verlo
    protected float campo3 = 5; //protected: solamente las clases que ereden podran verla
    float campo4 = 4; // por defecto se inicia en provado

    // Start is called before the first frame update
    void Start()
    {
        campo1 = SumaFlotante(campo3, campo4);
        Debug.Log(campo1);
        VuelveCeroAlNuemro(out campo1);
        Debug.Log(campo1);
        ClaseNormal miclase = new ClaseNormal(campo3, campo4);
        campo1 = miclase.SumarFlotantes(campo3, campo4);
        Debug.Log(campo1);
        campo1 = ClaseNormal.MultiplicarFlotantes(campo3, campo4);
        Debug.Log(campo1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    /// <summary>
    /// funciones propias
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public float SumaFlotante(float a, float b)
    {
        return a + b;
    }

    public void VuelveCeroAlNuemro(out float numero)
    {
        numero = 0;
    }
    /// <summary>
    /// propiedades
    /// </summary>
    public int propiedad1 { get; set; }

    public bool propiedad2 { get; set; }

    public float propiedadSoloLectura { get; }


}
