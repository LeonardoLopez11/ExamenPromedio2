using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class mercado : MonoBehaviour
{
    public Player player;
    
    public GameObject PanelUI;
    public string mensajeBienvenida = "Bienvenido. ¿Qué te gustaría comprar?";
    public int precioSemillas = 0; 
    public int precioAnimal = 0;
    
    private bool enTienda = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador")) 
        {
            enTienda = true;
            MostrarMensaje(mensajeBienvenida);
            ComprarSemillas();
            ComprarAnimal();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            enTienda = false;
            LimpiarMensaje();
        }
    }
    private void MostrarMensaje(string mensaje)
    {
        PanelUI.SetActive(true);
        
        
    }

    private void LimpiarMensaje()
    {
        PanelUI.SetActive(false);
    }

    private void ComprarSemillas()
    {
        if (player.Dinero >= precioSemillas)
        {
            
            player.Dinero -= precioSemillas;
            Debug.Log("Has comprado semillas");
            player.InventarioSemillas++;
        }
    }

    private void ComprarAnimal()
    {
        if (player.Dinero >= precioAnimal)
        {
            
            player.Dinero -= precioAnimal;
            Debug.Log("Compraste un animal");
            player.InventarioAnimales++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
