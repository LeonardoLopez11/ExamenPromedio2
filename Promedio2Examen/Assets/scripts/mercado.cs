using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Mercado : MonoBehaviour
{
    public Player player;


    
    public GameObject PanelUI;
    
    public int precioSemillas = 10; 
    public int precioAnimal = 20;
    

    private bool enTienda = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Jugador")) 
        {
           
            enTienda = true;
            MostrarTienda();
            ComprarSemillas();
            ComprarAnimal();
            VenderSemillas();
            VenderAnimales();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Jugador"))
        {
            enTienda = false;
            LimpiarTienda();
            
        }
    }
    private void MostrarTienda()
    {
        PanelUI.SetActive(true);
        


        
    }

    private void LimpiarTienda()
    {
        PanelUI.SetActive(false);
    }

    public void ComprarSemillas()
    {
        if (player.Dinero >= precioSemillas)
        {

            if (player.Dinero >= precioSemillas)
            {

                player.Dinero -= 10; ;
                Debug.Log("Has comprado semillas");
                player.InventarioSemillas++;
                
            }
        }
    }

    public void ComprarAnimal()
    {
        if (player.Dinero >= precioAnimal)
        {
            player.Dinero -= 20;
            player.Dinero -= precioAnimal;
            Debug.Log("Compraste un animal");
            player.InventarioAnimales++;
        }
    }
    public void VenderSemillas()
    {
        if (player.InventarioSemillas > 0)
        {

            player.Dinero+=10;
            Debug.Log("Vendiste Semillas");

            player.InventarioSemillas--;

        }

    }

    public void VenderAnimales()
    {

        if (player.InventarioAnimales > 0) { }
        {

            player.Dinero += 10;
            Debug.Log("Vendiste animales");
            player.InventarioAnimales--;
        }

    }
    void Start()
    {
        

    }



    void Update()
    {
        
    }
}
