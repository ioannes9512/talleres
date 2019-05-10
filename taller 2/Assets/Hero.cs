using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// se crean dos variables una de tipo gameobject y otroa de tipo vector3
/// </summary>
public class Hero : MonoBehaviour
{
    GameObject hero;
    Vector3 posicion;
    /// <summary>
    /// se hace la afirmacionde del objeto
    /// se cambia el nombre del objeto
    /// se le añade un rigidbody al objeto
    /// se accede las constraits del rigidbody del objeto para frezeearlas
    /// se deshabilita la gravedad del objeto
    /// se le asigna una posicion al objeto
    /// se le agrega el componente control"el script que contiene los axis que mueven al heroe"
    /// se le agrega una camara al objeto
    /// </summary>
    void Start()
    {
        hero = gameObject;
        hero.name = "Hero";
        hero.GetComponent<Renderer>().material.color = Color.red;
        hero.AddComponent<Rigidbody>();
        hero.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        hero.GetComponent<Rigidbody>().useGravity = false;
        hero.transform.position = new Vector3(0, 1f, 0);
        hero.AddComponent<Control>();
        hero.AddComponent<Camera>();








    }

    
}
