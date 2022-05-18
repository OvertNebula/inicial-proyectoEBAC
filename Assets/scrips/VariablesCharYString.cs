using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharYString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = '1';
        int ValorEntero = 0;
        if (!int.TryParse(c.ToString(),out ValorEntero))
        {
            Debug.LogError("eso no es un tipo de dato valido");
        }
        //char c = '9';
        //int ValorEntero = int.Parse(c.ToString());
        //int ValorEntero = c - '0';
        //int ValorEntero = (int)char.GetNumericValue(c)+5;
        Debug.Log(ValorEntero);

        char miCaracter;
        string miString = "hola desde EBAC";
        string miSegundoString = miString.ToUpper();
        //string miSegundoString = miString.Replace('e','E');
        string miTerserString = miString + " " + miSegundoString;
        string ejemploEscape = "c:\\User\\Loki\nDocumentod";
        miCaracter = miString[3];
        string miNombre = "Loki";
        string misApellidos = "Samano Gonazález";
        string miPrimerApellido = misApellidos.Substring(0, 6);
        string salidaDeSumas = "mi nombre es: " + miNombre + "y mis apellidos son" + misApellidos;
        string salida = $"Mi nombre es: {miNombre} y mis apellidos son {misApellidos}";
        int longitud = miString.Length;
        Debug.Log(salida);
        Debug.Log(miPrimerApellido);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
