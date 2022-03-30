using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//6. Realizá un programa que permita el ingreso por Inspector de un valor entero 
//mayor que 0 en una variable llamada num1 y muestre un mensaje por pantalla 
//indicando &quot;el número es par&quot; o &quot;el número es impar&quot;. 
//Deberá utilizar el operador “módulo” es el caracter %.
public class Guia1_ej06 : MonoBehaviour
{
    public int num1;
    // Start is called before the first frame update
    void Start()
    {
        int res;
        res = num1 % 2;
        if(num1 <= 0)
        {
            Debug.Log("El número ingresado debe ser mayor a 0");
        }
        else if (res == 1)
        {
            Debug.Log("el número es impar");
        }
        else if(res == 0)
        {
            Debug.Log("el número es par");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
