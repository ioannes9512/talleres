using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// esta clase se encarga de manejar todo lo relacionado con el ciudadano
/// se crea una variable de tipo gameobject la cual corresponde al ciudadanos y las propiedades 
/// se crea una varible tipo string el cual se encargara de entregar el mensaje propuesto en la actividad
/// se crea una variable de tipo entero el cual sera usado para entregar la edad
/// se crea una variable de tipo string la cual sera usada para entregar el nombre del ciuddadano
/// se crea un enum cuyos elementos corresponden a los nombres que se le asignaran al ciudadano
/// se crea una estructura que contiene los datos del ciudadano
/// </summary>
public class Citizen : MonoBehaviour
{
    GameObject citizen;
    string mensaje;
    int edad;
    string Nombres;
    public enum nombres
    {
      pablo,hilario,sergio,ramon,socorro,auxilio,jose,maria,luisa,nicanor,neptalí,eulalia,jacinta,ufano,candido,teodosia,
      castulo,gervasia,eufemio,higinio

    }
    public struct Stats
    {
        public int edad;
        public string nombre;
    }
    /// <summary>
    /// se crea una instancia del gameobject citizen
    /// se accede al material del objeto para cambiar su color 
    /// se cambia el nombre del objeto
    /// se iguala la variable tipo string declarada en la clase al enum en un rango aleatorio y luego de eso se convierte en a un string
    /// se le asigna un rango aleatorio a variable entera declarada en la clase la cual corresponde a la edad para que con esto pueda asignar la edad en el rango establecido
    /// el objeto se genera en una posicion aleatoraia  de manera aleatoria 
    /// se le agrega un rigidbody al objeto
    /// </summary>
    void Start()
    {
        citizen = gameObject;
        citizen.GetComponent<Renderer>().material.color = Color.yellow;
        citizen.name = "Citizen";
        Nombres = ((nombres)Random.Range(0, 20)).ToString();
        edad = Random.Range(15, 100);
        citizen.transform.position = new Vector3(Random.Range(-25, 20), 0.4f, Random.Range(-20, 20));
        citizen.AddComponent<Rigidbody>();

    }
    /// <summary>
    ///  este constructor se encarga de todo lo relacionado con los datos del ciudadnos
    ///  se crea una instancia del constructor
    ///  se accede a la edad y al nombre contenido en la estructura
    ///  retorna los datos contenidos en el constructor
    /// </summary>
    /// <returns></returns>
    public Stats getcitizenstats()
    {
        Stats stats = new Stats();
        stats.edad = edad;
        stats.nombre = Nombres;
        return stats;     


    }

   
}
