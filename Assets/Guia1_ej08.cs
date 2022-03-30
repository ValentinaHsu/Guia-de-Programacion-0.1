using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//8. Crear una variable entera que pueda ser modificada desde el Inspector.
//Suponiendo que el primer día de la semana es el Domingo, mostrar el nombre 
//del día correspondiente al valor de la variable “dia”. Si el día no está en 
//el rango permitido debe emitir por pantalla el mensaje de error "El día 
//ingresado no es válido";.
public class Guia1_ej08 : MonoBehaviour
{
    public int dia;
    // Start is called before the first frame update
    void Start()
    {
        string[] weekDays = new string[8] { "no existe", "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
        if (dia <= 0)
        {
            Debug.Log("El día ingresado no es válido");
        }
        else if (dia >= 8)
        {
            Debug.Log("El día ingresado no es válido");
        }

        Debug.Log(weekDays[dia]);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
