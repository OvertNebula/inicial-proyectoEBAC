using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringYSwitch : MonoBehaviour
{
    public GameObject CuboColor;

    float flotante = 5.0493F;
    string s1;

    int valor = 0;
    int bajo = 0;
    int alto = 3;
    enum colordelcubo
    {
        blanco,
        negro,
        azul,
        rojo,
    }

    // Start is called before the first frame update
    void Start()
    {
        var meshRendered = CuboColor.GetComponent<MeshRenderer>().material;

        valor = Random.Range(bajo, alto);
        Debug.Log("el numero de color en el cubo es" + valor);
        switch (valor)
        {
            case (int)colordelcubo.blanco:
                meshRendered.color = Color.white;
                break;
            case (int)colordelcubo.negro:
                meshRendered.color = Color.black;
                break;
            case (int)colordelcubo.azul:
                meshRendered.color = Color.blue;
                break;
            case (int)colordelcubo.rojo:
                meshRendered.color = Color.red;
                break;

               
        }
        s1 = flotante.ToString("1,2");
        Debug.Log("s1 es" + s1);

        //flotante = s1.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        char letra1;
        char letra2;
        char letra3;
        char letra4;
        char letra5;
        string MiNombre = "Steven Samano González ";
        letra1 = MiNombre[3];
        Debug.Log(letra1);
        letra2 = MiNombre[20];
        Debug.Log(letra2);
        letra3 = MiNombre[5];
        Debug.Log(letra3);
        letra4 = MiNombre[17];
        Debug.Log(letra4);
        letra5 = MiNombre[12];
        Debug.Log(letra5);
        string separacion1 = MiNombre.Substring(0,6);
        string[] corte1 = MiNombre.Split('6');
        Debug.Log(separacion1);
        string separacion2 = MiNombre.Substring(7,12);
        //string[] corte2 = MiNombre.Split('13');
        Debug.Log(separacion2);
        string separacion3 = MiNombre.Substring(14,21);
        //string[] corte3 = MiNombre.Split('22');
        Debug.Log(separacion3);


    }
}
