using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plantacion : MonoBehaviour
{
    public GameObject plantaPrefab; 
    private bool estaPlantado = false;
    public Slider BarradeProgreso;
    public float tiempoCrecimiento = 1;

   
    private float tiempoTranscurrido = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (estaPlantado)
        {
            tiempoTranscurrido += Time.deltaTime;
            CargarBarraDeProgreso();

            if (tiempoTranscurrido >= tiempoCrecimiento)
            {
                CultivarPlanta();
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            if (Input.GetMouseButtonDown(0) && !estaPlantado)
            {
                Plantar();
            }

        }
        
    }

    void CultivarPlanta()
    {
        
        GameObject nuevaPlanta = Instantiate(plantaPrefab, transform.position, Quaternion.identity);

        
        nuevaPlanta.transform.SetParent(transform);


        tiempoTranscurrido = 0f;
        estaPlantado = false;

        
        BarradeProgreso.gameObject.SetActive(false);
    }
    void CargarBarraDeProgreso()
    {
        float progreso = tiempoTranscurrido / tiempoCrecimiento;
        BarradeProgreso.value = progreso;
    }
    public void Plantar()
    {
        if (!estaPlantado)
        {
            estaPlantado = true;
            BarradeProgreso.gameObject.SetActive(true);
        }
    }
}
