using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiempoEscena : MonoBehaviour
{

    //objeto GameManager gameManager
    private readonly GameManager gameManager;

    public float tiempo_start = 0.0f;
    public float tiempo_end = 0.0f;
    public string escena;

    // Start is called before the first frame update

    [System.Obsolete]
    private void Update()
    {
        tiempo_start += Time.deltaTime;
        if(tiempo_start >= tiempo_end)
        {
            Application.LoadLevel(escena);

        }
    }

}
