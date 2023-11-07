using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantacion : MonoBehaviour
{
    public GameObject plantaPrefab; 
    private bool estaPlantado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !estaPlantado)
        {
            Plantar();
        }
    }
    void Plantar()
    {
        
        GameObject nuevaPlanta = Instantiate(plantaPrefab, transform.position, Quaternion.identity);

        
        nuevaPlanta.transform.SetParent(transform);

        
        estaPlantado = true;
    }
}
