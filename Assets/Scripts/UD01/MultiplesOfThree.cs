using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Múltiplos de 3 entre 0 y 100:");
        List<int> multiples = new List<int>();

        // Recorrer del 0 al 100
        for (int i = 0; i <= 100; i++)
        {
            // Comprobar si el número es múltiplo de 3 si al dividirlo entre 3 el resultado del resto es 0
            if (i % 3 == 0)
            {
                // Mostrar el número en la consola
                multiples.Add(i);
            }
        }
        Debug.Log(string.Join(", ", multiples));
    }
}
