using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Heladeria : MonoBehaviour
{
    public string helado;
    public float cuantoHelado;
    float descuentoFrutilla = 0.1f;
    float maximoHelado = 3000;
    float minimoHelado = 250;
    float precioGramo = 1.25f;
    float precioTotal;
    

    // Start is called before the first frame update
    void Start()
    {
        if (cuantoHelado < minimoHelado || cuantoHelado > maximoHelado)
        {
            Debug.Log("La cantidad elegida esta fuera de los parametros, (250, 3000)");
            return;
        } else
        {
            if (helado == "CHO" || helado == "DDL")
            {
                precioTotal = cuantoHelado * precioGramo;
                Debug.Log("El helado elegido es" + helado + "y el precio total es de " + precioTotal);
            } else if (helado == "FRU")
            {
                precioTotal = cuantoHelado * precioGramo;
                precioTotal = precioTotal - precioTotal * descuentoFrutilla;
                Debug.Log("El costo por el helado mas el descuento es de " + precioTotal);
            }
            else
            {
                Debug.Log("El codigo de helado no es valido");
                return;
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
