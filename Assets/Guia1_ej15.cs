using System.Collections;
using System.Collections.Generic;
using UnityEngine;
////15. Existen dos reglas que identifican dos conjuntos de valores: 
//- El número es de un solo dígito.  
//- El número es impar.  
//A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA, 
//estaEnB, estaEnAmbos y noEstaEnNinguno el valor verdadero o falso, según corresponda,  para 
//indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos o a  ninguno,
//respectivamente. Definí un lote de prueba de varios números y probá el algoritmo,  escribiendo
//los resultados. 

public class Guia1_ej15 : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        bool estaEnA;
        bool estaEnB;
        bool estaEnAmbos;
        bool noEstaEnNinguno;
        int imPar = num % 2;

        if (imPar == 1)
        {
            if (num <= 9)
            {
                estaEnAmbos = true;
                Debug.Log("Esta en Ambos = " + estaEnAmbos);
            }
            else
            {
                estaEnB = true;
                Debug.Log("Esta en B = " + estaEnB);
            }
        }

        if (imPar == 0)
        {
            if (num > 9 )
            {
                noEstaEnNinguno = true;
                Debug.Log("No esta en ninguno = " + noEstaEnNinguno);
            }
            else
            {
                estaEnA = true;
                Debug.Log("Esta en A = " + estaEnA);
            }
        }

    } 
        
           
}

  

