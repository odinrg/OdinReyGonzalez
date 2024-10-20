using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Month : MonoBehaviour
{

    // Variable publica global para cambiar desde el inspector
    public int MonthNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        //Obtenemos el nombre del mes, o nulo si no es un número del 1 al 12 y mostramos por log
        string monthName = GetMonthName(MonthNumber);
        if (monthName != null)
        {
            Debug.Log("El mes correspondiente es: " + monthName);
        }
        else
        {
            Debug.Log("Por favor, introduce un número entre 1 y 12.");
        }
    }

    //Obtenemos el string correspondiente según el número de mes introducido
    private string GetMonthName(int month)
    {
        switch (month)
        {
            case 1:
                return "Enero";
            case 2:
                return "Febrero";
            case 3:
                return "Marzo";
            case 4:
                return "Abril";
            case 5:
                return "Mayo";
            case 6:
                return "Junio";
            case 7:
                return "Julio";
            case 8:
                return "Agosto";
            case 9:
                return "Septiembre";
            case 10:
                return "Octubre";
            case 11:
                return "Noviembre";
            case 12:
                return "Diciembre";
            default:
                return null;
        }
    }
}
