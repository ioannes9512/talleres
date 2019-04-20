using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie 
{
    private string Nombre;
    Renderer colorasigna;
    private int Daño;
    GameObject figura;
    int alea = 0;
    string mensaje;
    public zombie(string nombre, int daño)
    {
        this.Nombre = nombre;
        alea = UnityEngine.Random.Range(1, 4);
        this.Daño = daño;
        figura = GameObject.CreatePrimitive(PrimitiveType.Cube);
        figura.name = "Zombie";
        if(alea == 1)
        {
            figura.GetComponent<Renderer>().material.color = Color.cyan;
        }
        if(alea == 2)
        {
            figura.GetComponent<Renderer>().material.color = Color.green;
        }
        if(alea == 3)
        {
            figura.GetComponent<Renderer>().material.color = Color.magenta;
        }

        Vector3 posicion = new Vector3();
        posicion.x = UnityEngine.Random.Range(-20, 25);
        posicion.y = 0.56f;
        posicion.z = UnityEngine.Random.Range(-35, 30);

        




    }
    public string Getname()
    {
        return Nombre;
    }
    public void Setname(string nombre)
    {
        this.Nombre = nombre;
    }

    public string stats()
    {
      if (alea == 1)
      {
        mensaje = "Hola soy" + Getname() + " " + "soy un zombie color cyan";
      }
      if(alea == 2)
      {
        mensaje = "Hola soy" + Getname() + " " + "soy un zombie color verde";
      }
      if(alea == 3)
      {
        mensaje = "Hola soy" + Getname() + " " + "soy un zombie color magenta";
      }
        return mensaje;

    }
}

public class Civitas
{
    public GameObject citizen;
    private string nombre;
    private int edad;
    private string inf;
    string[] listanombres = new string[]
    {
     "hilario","obdulio","neptalí","dagoberto","sergio","nicanor","epifanio","Heliodoro","sabina","higinio","ufano","candido","jacinta","teodosia","leonila","teodulo","tiburcio","celso","Regulo","eustaquio"
    };

    public Civitas(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
        citizen = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        citizen.name = "Citizen";
        Vector3 pos = new Vector3(UnityEngine.Random.Range(-20, 28), 1.08f, UnityEngine.Random.Range(-37, 32));
        citizen.transform.position = pos;
    }
    public string Mensaje()
    {
        inf = "Hola soy:" + this.nombre + "  " + "tengo:" + this.edad + "años";
        return inf;
    }

    public void Datospersonales()
    {
        int alea2 = UnityEngine.Random.Range(0, 19);
        nombre = listanombres[alea2];
        edad = UnityEngine.Random.Range(15, 110);
    }















}