using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//1. Realizá un programa donde se cree una variable entera llamada num1, 
//que inicialmentevaldrá 0. Luego incrementá su valor en 2 y mostralo por 
//pantalla.Después mostrá el resultado de multiplicarlo por sí mismo.  

    public class Guia1_ej01: MonoBehaviour
{
    public int num1 = 0;
    // Start is called before the first frame update
    void Start()
    {       
        int multiplo;
        Debug.Log(num1);
        num1 = num1 + 2;
        Debug.Log(num1);
        multiplo = num1 * num1;
        Debug.Log(multiplo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
