using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Botones : MonoBehaviour
{
    //objeto GameManager gameManager
    private GameManager gameManager;

    //botones
	
    public Button Botoninicar, Creditos, Salir, Volver;

    private void Start()
    {
        //Busco mi objeto Game Manager
        gameManager = FindObjectOfType<GameManager>();
       
        //Añado al botoninicio la accion a ejecutar al hacer click
        if (Botoninicar)
        {
            Botoninicar.GetComponent<Button>().onClick.AddListener(() => gameManager.cambiarEscena("Comienzo del juego"));
        }

        if (Creditos)
        {
            Creditos.GetComponent<Button>().onClick.AddListener(() => gameManager.cambiarEscena("Creditos"));

        }
        if (Volver)
        {
            Volver.GetComponent<Button>().onClick.AddListener(() =>cambiarEscena("Menu"));
        }

        if (Salir)
        {
            Salir.GetComponent<Button>().onClick.AddListener(() => Application.Quit());
        }
    }

    // Update is called once per frame
    public void cambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);

    }

}
