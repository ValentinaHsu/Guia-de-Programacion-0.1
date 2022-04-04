using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////14. Construir un programa que simule el funcionamiento de una calculadora que puede  realizar las 
///cuatro operaciones aritméticas básicas (suma, resta, producto y división) con  valores numéricos enteros.  
//Se debe especificar la operación que se desea realizar ingresando una letra por Inspector 
//(s para la suma,  r para la resta, p para el producto y d para la división) y luego, deberán 
//  ingresarse dos números enteros para así realizar la operación. Informar el resultado por 
//pantalla.  Nota: Se recomienda el empleo de una sentencia switch. 

public class Guia1_ej14 : MonoBehaviour
{
    public string letra; 
    public int num1, num2;
    // Start is called before the first frame update
    void Start()
    {
        int total;
        switch (letra)
        {
            case "s":
                total = num1 + num2;
                Debug.Log(total);
                break;

            case "r":
                total = num1 - num2;
                Debug.Log(total);
                break;

            case "p":
                total = num1 * num2;
                Debug.Log(total);
                break;

            case "d":
                total = num1 / num2;
                Debug.Log(total);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
