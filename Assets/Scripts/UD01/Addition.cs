using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addition : MonoBehaviour
{
    //Variables globales publicas para editar desde el inspector
    public int InputNumber;

    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;

        // Recorrer desde 1 hasta el número introducido
        for (int i = 1; i <= InputNumber; i++)
        {
            sum += i; // Sumar el número actual a la suma total
        }

        // Mostrar el resultado en la consola
        Debug.Log("La suma de los números del 1 al " + InputNumber + " es: " + sum);
    }
}
