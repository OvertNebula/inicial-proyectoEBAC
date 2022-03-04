using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ob : MonoBehaviour
{

    public GameObject objeToOb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        GameObject TempGameObject = Instantiate<GameObject>(objeToOb);
        var meshRenderedMaterial = objeToOb.GetComponent<MeshRenderer>().material;
        meshRenderedMaterial.color = Color.blue;
        Debug.Log("OnDisable");
    }

    private void OnEnable()
    {
        GameObject TempGameObject = Instantiate<GameObject>(objeToOb);
        var meshRenderedMaterial = objeToOb.GetComponent<MeshRenderer>().material;
        meshRenderedMaterial.color = Color.white;
        Debug.Log("OnEnable");
    }
}
