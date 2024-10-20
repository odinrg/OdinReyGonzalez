using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Números impares entre 0 y 100:");
        List<int> odd = new List<int>();

        // Recorremos los números del 0 al 100
        for (int i = 0; i <= 100; i++)
        {
            // Comprobar si el número es impar viendo si el resto de dividirlo entre 2 no es 0
            if (i % 2 != 0)
            {
                // Agregar el número a la lista
                odd.Add(i);        
            }
        }
        Debug.Log(string.Join(", ", odd));
    }
}
