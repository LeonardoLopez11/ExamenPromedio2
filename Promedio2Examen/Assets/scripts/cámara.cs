using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cámara : MonoBehaviour
{
    public Transform jugador; 

    public float suavidad = 5f; 

    private Vector3 offset; 

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - jugador.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LateUpdate()
    {
        Vector3 nuevaPosicion = jugador.position + offset;
        transform.position = Vector3.Lerp(transform.position, nuevaPosicion, suavidad * Time.deltaTime);
    }
}
