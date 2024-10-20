using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingOrder : MonoBehaviour
{
    //Variables globales publicas para editar desde el inspector
    public int Number1;
    public int Number2;
    public int Number3;

    // Start is called before the first frame update
    void Start()
    {
        // Comprobar si los números están en orden creciente
        if (Number1 > Number2 && Number2 > Number3)
        {
            Debug.Log("Los números están en orden decreciente.");
        }
        else
        {
            Debug.Log("Los números NO están en orden decreciente.");
        }
    }
}
