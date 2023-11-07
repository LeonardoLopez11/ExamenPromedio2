using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class corralcontrol : MonoBehaviour
{
    public GameObject animalPrefab;
    private bool animalColocado = false;
    public Slider BarradeProgreso;
    public float tiempoReproduccion = 1;
    public int animalesColocados = 0;
    private float tiempoTranscurrido = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (animalColocado)
        {
            tiempoTranscurrido += Time.deltaTime;
            CargarBarraDeProgreso();

            if (tiempoTranscurrido >= tiempoReproduccion)
            {
                
                AnimalReproduccion();
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            if (Input.GetMouseButtonDown(0) && !animalColocado)
            {
                ColocarAnimal();
                
            }

        }

    }
    void AnimalReproduccion()
    {
        if (animalesColocados >= 2)
        {

            Debug.Log("Conseguiste otro animal!");
            ColocarAnimal();
            GameObject nuevoAnimalextra = Instantiate(animalPrefab, transform.position, Quaternion.identity);


            nuevoAnimalextra.transform.SetParent(transform);
        }
        GameObject nuevoAnimal = Instantiate(animalPrefab, transform.position, Quaternion.identity);


        nuevoAnimal.transform.SetParent(transform);


        tiempoTranscurrido = 0f;
        animalColocado = false;


        BarradeProgreso.gameObject.SetActive(false);
    }
    void CargarBarraDeProgreso()
    {
        float progreso = tiempoTranscurrido / tiempoReproduccion;
        BarradeProgreso.value = progreso;
    }
    public void ColocarAnimal()
    {
        if (!animalColocado)
        {
            animalesColocados++;
            Debug.Log("Hay un animal colocado");
            animalColocado = true;
            BarradeProgreso.gameObject.SetActive(true);
        }
    }
}

