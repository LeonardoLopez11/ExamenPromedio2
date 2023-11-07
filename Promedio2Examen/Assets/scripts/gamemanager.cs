using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("nivel");

    }
    public void RegresarMenú()
    {
        SceneManager.LoadScene("Main menú");

    }
}
