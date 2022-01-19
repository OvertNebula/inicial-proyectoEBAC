using UnityEngine;

public class HolaMundo : MonoBehaviour
{



    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("aglo paso");

        Debug.LogWarning("algo salio medianamente mal");
        Debug.LogError("algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("hola desde FixedUpdat cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("hola desde late Update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("el bojeto ha sido habilitado");
    }
    private void OnDisable()
    {
        Debug.LogWarning("el objeto ha sido inabilitado");
    }

}



  

