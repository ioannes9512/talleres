using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncitizen 
{
    private string Nombre;
    private int edad;
    GameObject citizen;

    public spawncitizen(string nombre,int edad)
    {
        this.Nombre = nombre;
        this.edad = edad;
        citizen = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        Vector3 posicion = new Vector3(UnityEngine.Random.Range(-20, 25), 1f, UnityEngine.Random.Range(-35, 30));
        citizen.name = "Citizen";
        citizen.transform.position = posicion;
        citizen.GetComponent<Renderer>().material.color = Color.grey;

    }
    public string Stats()
    {
        string stats = "hola soy de la ciudad  me llamo:" + asignanombre() + " " + "tengo" + asignaedad() + "años";
        return stats;

    }

    public string asignanombre()
    {
        return Nombre;
    }
    public void colocanombre(string nombre)
    {
        this.Nombre = nombre;
    }
    public int asignaedad()
    {
        return edad;
    }
    public void colocaedad(int edad)
    {
        this.edad = edad;
    }
































}
