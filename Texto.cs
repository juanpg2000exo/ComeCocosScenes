using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto : MonoBehaviour
{
    //Velocidad del texto
    public float velocidadTexto = 20;

    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 posicion = transform.position;
        Vector3 vectorArriba = transform.TransformDirection(0, 1, 0);
        posicion += vectorArriba * velocidadTexto * Time.deltaTime;
        transform.position = posicion;
    }
}

