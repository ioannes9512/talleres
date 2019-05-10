using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// en esta clase se maneja todo lo referente al ciudadano
/// </summary>
public class Ciudadano
{ /// <summary>
  /// se declaran 3 variables una de tipo gameobject
  /// una de tipo estring y una de tipo entero
 /// </summary>
    private string Nombre;
    private int edad;
    GameObject citizen;
    /// <summary>
    /// se crea un constructor el cual recive 2 parametros uno de tipo string y otro de tipo entero
    /// luego la varible tipo string que se definion en la clase se iguala al parametro string del constructor
    /// asi mismo la variable tipo entero defiida en la clase se iguala al parametro tipo int del constructor
    /// luego se genera una primitiva tipo cilindro con el gameobject
    /// despues se crea una variable de tipo vector 3 para referenciar la posicion del onjeto
    /// luego se cambia del objeto
    /// y luego se iguala la posicion del objeto a  los que fueron configurados en la variable tipo vector 3
    /// y luyego se accede al componente renderer y se cambia el color a gris
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="edad"></param>
    public Ciudadano(string nombre,int edad)
    {
        this.Nombre = nombre;
        this.edad = edad;
        citizen = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        Vector3 posicion = new Vector3(UnityEngine.Random.Range(-25, 25), 2f, UnityEngine.Random.Range(-35, 35));
        citizen.name = "Citizen";
        citizen.transform.position = posicion;
        citizen.GetComponent<Renderer>().material.color = Color.grey;

    }
    /// <summary>
    /// luego se crea una instancia la cual se encargara de entregar el mensaje designado en la actividad 
    /// </summary>
    /// <returns></returns>
    public string Stats()
    {
        string stats = "hola soy de la ciudad  me llamo:" + asignanombre() + " " + "tengo" + asignaedad() + "años";
        return stats;

    }
    /// <summary>
    /// se crea una instancia la cual permite asignar el nombre al ciudadano
    /// </summary>
    /// <returns></returns>
    public string asignanombre()
    {
        return Nombre;
    }
    /// <summary>
    /// en esta instancia se iguala a la variable string a al parametro del constructor ciudadadno
    /// </summary>
    /// <param name="nombre"></param>
    public void colocanombre(string nombre)
    {
        this.Nombre = nombre;
    }
    /// <summary>
    /// en esta instancia se asigna la edad del ciuadadano
    /// </summary>
    /// <returns></returns>
    public int asignaedad()
    {
        return edad;
    }
    /// <summary>
    /// este metodo se encarga de colocar la edad al ciudadano
    /// </summary>
    /// <param name="edad"></param>
    public void colocaedad(int edad)
    {
        this.edad = edad;
    }
































}
