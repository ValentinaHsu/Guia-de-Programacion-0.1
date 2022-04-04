using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//13. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente  manera:  
//• Si trabaja 40 horas o menos se le paga $16 por hora (crear una constante para almacenar  el 16) 
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20  por cada hora
//extra. (crear una constante para almacenar el 20) 
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por  pantalla el salario 
//correspondiente. 

public class Guia1_ej13 : MonoBehaviour
{
    public int horas;
    // Start is called before the first frame update
    void Start()
    {
        int horasextra;
        int pagaxh = 16;
        int pago;
        if (horas <= 40)
        {
            pago = horas * pagaxh;
            Debug.Log("Horas de trabajo: " + horas + "\n" +
                "Salario Semanal: " + pago);
        }
        else if (horas > 40)
        {
            horasextra = 40 * pagaxh + (horas - 40) * 20 ;
            Debug.Log("Horas de trabajo: " + horas + "\n" +
                "Salario Semanal: " + horasextra);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
