using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//11. Realizá un programa que resuelva el siguiente problema:
//Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:
//YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
//producto comprado.Mostrá a modo de ticket, la información ingresada y el monto a pagar.
//Modelo de Ticket:
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx
public class Guia1_ej11 : MonoBehaviour
{
    public string date = "YYYYMMDD", nombre, nomProd;
    public int cant, precio;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Fecha de Compra: " + date + "\n" +
        "Nombre del Comprador: " + nombre + "\n" +
        "Producto solicitado: " + nomProd + "\n" +
        "Cantidad solicitada: " + cant + "\n" +
        "Precio Unitario: $" + precio + "\n" +
        "Total a Pagar: $" + precio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
