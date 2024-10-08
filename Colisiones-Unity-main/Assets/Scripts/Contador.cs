using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    //Declaración de variables
    [SerializeField] private Text textoContador;
    private int puntos = 0;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Incremento los puntos
        puntos++; //Incrementa en 1 el valor de la variable puntos (es lo mismo que puntos = puntos + 1
        
        //Actualizo el texto del contador de puntos
        textoContador.text = "Contador: " + puntos;
    }
}