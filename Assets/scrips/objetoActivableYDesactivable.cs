using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetoActivableYDesactivable : MonoBehaviour
{
    public GameObject objectToActibableYDesactibable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            objectToActibableYDesactibable.SetActive(false); //desactivar

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            objectToActibableYDesactibable.SetActive(true); //activar

        }
    }
}
