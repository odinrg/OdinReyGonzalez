using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromSmallestToLargest : MonoBehaviour
{
    //Variables globales publicas para editar desde el inspector
    public int Number1;
    public int Number2;
    public int Number3;

    // Start is called before the first frame update
    void Start()
    {

        // Crea un array con los tres n�meros
        int[] numbers = new int[] { Number1, Number2, Number3 };

        //Se podr�an ordenar de forma rudimentaria con if comparando los n�meros y determinando el orden
        //pero vamos a utilizar un m�todo propio de los arrays 
        // Ordena el array de menor a mayor con un sort
        System.Array.Sort(numbers);

        // Muestra los n�meros en pantalla
        Debug.Log("N�meros de menor a mayor: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);

    }
}
