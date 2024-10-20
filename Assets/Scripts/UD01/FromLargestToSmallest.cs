using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromLargestToSmallest : MonoBehaviour
{
    //Variables globales publicas para editar desde el inspector
    public int Number1;
    public int Number2;
    public int Number3;

    // Start is called before the first frame update
    void Start()
    {

        // Crea un array con los tres números
        int[] numbers = new int[] { Number1, Number2, Number3 };

        //Se podrían ordenar de forma rudimentaria con if comparando los números y determinando el orden
        //pero vamos a utilizar un método propio de los arrays 
        // Ordena el array de menor a mayor con un sort que ordena de menor a mayor 
        System.Array.Sort(numbers);
        //y le damos la vuelta
        System.Array.Reverse(numbers);

        // Muestra los números en pantalla
        Debug.Log("Números de mayor a menor: " + numbers[0] + ", " + numbers[1] + ", " + numbers[2]);

    }
}
