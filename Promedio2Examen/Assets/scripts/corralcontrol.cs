using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class corralcontrol : MonoBehaviour
{
    public GameObject cerdo;
    public GameObject vaca;
    private bool animalColocadocerdo = false;
    public Slider BarradeProgreso;
    public float tiempoReproduccion = 1;
    public int cerdosColocados = 0;
    public int vacasColocadas = 0;
    private float tiempoTranscurrido = 0;
    private bool animalColocadovaca = false;

    public Text carne;
    public Text leche;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (animalColocadocerdo)
        {
            tiempoTranscurrido += Time.deltaTime;
            CargarBarraDeProgreso();

            if (tiempoTranscurrido >= tiempoReproduccion)
            {
                
                AnimalReproduccionCerdo();
            }
        }
        if (animalColocadovaca)
        {
            tiempoTranscurrido += Time.deltaTime;
            CargarBarraDeProgreso();

            if (tiempoTranscurrido >= tiempoReproduccion)
            {

                AnimalReproduccionvaca();
                carne.enabled = true;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            if (Input.GetMouseButtonDown(0) && !animalColocadocerdo)
            {
                ColocarAnimalCerdo();
                
            }

        }
        if (other.CompareTag("Jugador"))
        {
            if(Input.GetKeyDown(KeyCode.E) && !animalColocadovaca)
                  
            {
                ColocarAnimalVaca();
                leche.enabled = true;
            }


        }
    }
    
    void AnimalReproduccionCerdo()
    {
        if (cerdosColocados >= 2)
        {

            Debug.Log("Conseguiste otro cerdo");
            ColocarAnimalCerdo();
            AnimalExtra();


            
        }
        GameObject nuevoAnimalcerdo = Instantiate(cerdo, transform.position, Quaternion.identity);


        


        tiempoTranscurrido = 0f;
        animalColocadocerdo = false;


        BarradeProgreso.gameObject.SetActive(false);
    }
    void CargarBarraDeProgreso()
    {
        float progreso = tiempoTranscurrido / tiempoReproduccion;
        BarradeProgreso.value = progreso;
    }
    public void ColocarAnimalCerdo()
    {
        if (!animalColocadocerdo)
        {
            cerdosColocados++;
            Debug.Log("Colocaste un cerdo");
           
            animalColocadocerdo = true;
            BarradeProgreso.gameObject.SetActive(true);
        }
    }
    void AnimalExtra()
    {
        GameObject nuevoAnimalextra = Instantiate(cerdo, transform.position, Quaternion.identity);
        tiempoTranscurrido = 0f;
        animalColocadocerdo = false;


        BarradeProgreso.gameObject.SetActive(false);
    }
    public void ColocarAnimalVaca()
    {
        if (!animalColocadovaca)
        {
            vacasColocadas++;
            Debug.Log("Colocaste una vaca");
            
            animalColocadovaca = true;
            BarradeProgreso.gameObject.SetActive(true);
        }
    }
    void AnimalReproduccionvaca()
    {
        if (vacasColocadas >= 2)
        {

            Debug.Log("Conseguiste otra vaca!");
            ColocarAnimalVaca();
            AnimalExtraVaca();



        }
        GameObject nuevoAnimalvaca = Instantiate(vaca, transform.position, Quaternion.identity);





        tiempoTranscurrido = 0f;
        animalColocadovaca = false;


        BarradeProgreso.gameObject.SetActive(false);
    }
    void AnimalExtraVaca()
    {
        GameObject nuevoAnimalextra = Instantiate(vaca, transform.position, Quaternion.identity);
        tiempoTranscurrido = 0f;
        animalColocadovaca = false;


        BarradeProgreso.gameObject.SetActive(false);
    }
}


