using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	

	//Objeto GameManager
	private readonly GameObject gameManager;

	public int tiempo = 0;

	
	private readonly bool cargarEscena;
	private readonly string escena;

	private void Start()
	{

		//Busco el objeto llamado GameManager
		GameObject gameManager = GameObject.Find("GameManager");

		//Le indico que no se destruya al cargar otra escena 
		//DontDestroyOnLoad(gameManager);

		if(SceneManager.GetActiveScene().name == "Preload"){
			SceneManager.LoadScene("Intro");
			

			if(Time.deltaTime == tiempo){
				SceneManager.SetActiveScene(SceneManager.GetSceneByName("Menu"));
				
			}
		}

	}

	public void cambiarEscena(string nombreEscena)
	{
		SceneManager.LoadScene(nombreEscena);
		
	}

}
