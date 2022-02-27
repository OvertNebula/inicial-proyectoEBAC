using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuboawake : MonoBehaviour
{
    public GameObject ObjectTOAWAKE;
    // Start is called before the first frame update
    void Start()
    {
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
    }
}
