using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlgebraBooleana : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limiteinferior = 0;
    int limitesuperior = 7;

    enum seleccionarcolor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    }

    // Start is called before the first frame update
    void Start()
    {
        //              ||  &&
        //   A B C      OR AND (A or B) and C)  ((A or B) or C)
        //   1 1 1       1  1          1                1
        //   1 1 0       1  1          0                1
        //   1 0 1       1  0          1                1
        //   1 0 0       1  0          0                1
        //   0 1 1       1  0          1                1
        //   0 1 0       1  0          0                1
        //   0 0 1       0  0          0                1
        //   0 0 0       0  0          0                0
        //
        //               A  B


        //variable1 = true;
        //variable2 = false;
        //variable3 = false;
        //if ((variable1 || variable2) && variable3)
        //{
        //    Debug.Log("la operacion 1 es verdadera");
        //}
        //else if ((variable1 || variable2) || variable3)
        //{
        //    Debug.Log("la operacion 2 es verdadera");
        //}
        //else if ((variable1 && variable2) || variable3)
        //{
        //    Debug.Log("la operacion 3 es verdadera");
        //}
        valor1 = Random.Range(limiteinferior, limitesuperior);
        Debug.Log(valor1);
        //if (valor1 >= 0)
        //{
        //    Debug.Log("el valor es pocitivo");
        //}
        //else
        //{
        //    Debug.Log("el valor es negativo");
        //}

        string resultado = (valor1 >= 0) ? "el valor es pocitivo" : "el valor es negativo";
        Debug.Log("resultado");
         //switch (valor1)
        //{
        //    case (int)seleccionarcolor.rojo:
        //        Debug.Log("el color seleccionado es rojo");
        //        break;
        //    case (int)seleccionarcolor.verde:
        //        Debug.Log("el color seleccionado es verde");
        //        break;
        //    case (int)seleccionarcolor.azul:
        //        Debug.Log("el color seleccionado es azul");
        //        break;
        //    case (int)seleccionarcolor.blanco:
        //        Debug.Log("el color seleccionado es blanco");
        //        break;
        //    case (int)seleccionarcolor.gris:
        //        Debug.Log("el color seleccionado es gris");
        //        break;
        //    default:
        //        Debug.Log("este valor no existe");
        //        break;
        //}
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
