using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboawake : MonoBehaviour
{
    public GameObject ObjectTOAWAKE;
    //public Rigidbody cuboColores;
    

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);

        Debug.Log("esta prendido");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        GameObject TempGameObject = Instantiate<GameObject>(ObjectTOAWAKE);
        Color c = new Color(Random.value, Random.value, Random.value);
        gameObject.GetComponent<MeshRenderer>().material.color = c;

        Debug.Log("esta apagado");
        
    }
    private void FixedUpdate()
    {
        
    }
}
