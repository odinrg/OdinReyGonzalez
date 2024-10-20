using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Even : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Números pares entre 0 y 100:");
        List<int> even = new List<int>();

        // Recorremos los números del 0 al 100
        for (int i = 0; i <= 100; i++)
        {
            // Comprobar si el número es impar viendo si el resto de dividirlo entre 2 es 0
            if (i % 2 == 0)
            {
                // Mostrar el número par en la consola
                even.Add(i);
            }
        }
        Debug.Log(string.Join(", ", even));
    }
}
