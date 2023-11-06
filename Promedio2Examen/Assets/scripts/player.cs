using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadmovimiento = 5;
    public int InventarioSemillas = 0;
    public int InventarioAnimales = 0;
    public int Dinero = 100;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * velocidadmovimiento * Time.deltaTime;
        transform.Translate(movement);

    }
}
