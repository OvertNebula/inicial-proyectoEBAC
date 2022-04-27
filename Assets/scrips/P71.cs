using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P71 : MonoBehaviour
{
    public GameObject objeToP71;

    public bool tuVariableBool71 = false;
    //bool variable1;
    //bool variable2;
    //int verdadero = 1;
    //int falso = 0;
    private void FixedUpdate()
    {
        
    }
    //Start is called before the first frame update
    //public GameObject toggler;
    void Update()
    {
        objeToP71 = this.gameObject;

        //maNGItuVariableBool71 = !tuVariableBool71;
        //freim0 tuVarible71 = false
        //freim1 false = !true =>tue
        //freim2 true =!true => false

        //print (toggler.GetComponent<Toggle>().isOn);

        var meshRenderedMaterial = objeToP71.GetComponent<MeshRenderer>().material;

        //variable1 = true;
        //variable2 = false;
        //Random.Range(variable1, variable2);
        //Random.Range(verdadero, falso);


        //if (tuVariableBool)
        //{
        //    tuVariableBool = false;
        //}
        //else
        //{
        //    tuVariableBool = true;
        //
        //}

        if (tuVariableBool71)
        {
            meshRenderedMaterial.color = Color.white;
            Debug.Log("P71 verdadero");
        }
        else
        {
            meshRenderedMaterial.color = Color.black;
            Debug.Log("P71 falso");
        }
    }

    // Update is called once per frame
    //void Update()
    //{
    //    
    //}
    //public void userToggle(bool tog)
    //{
    //    print(tog);   
    //}
}
