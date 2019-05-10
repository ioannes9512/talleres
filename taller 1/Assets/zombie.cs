using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// en esta clase se crea todo lo relacionado con el zombie 
/// </summary>
public class Zombie   
{ /// <summary>
  /// se crean las variables las cuales seran utilizadas en el contrustructores
  /// un game object el cual servira para generar un objeto junto y acceder a los componentes de este
  /// una variable tipo string llamada nombre la cual sera usada para igualarla a los parametros del constructor 
  /// una variable de tipo int para igualarla al parametro tipo int del costructor
  /// una variable de tipo int que sera usada en el condicional if para utilizarla en un rango aletorio dentro de un condicional en el constructor
  /// una variable string la cual sera usada para imprimir por consola el mensaje estipulado en la actividad
  /// </summary>
    private string Nombre;

    

    private int Daño;
    GameObject figura;

    int alea = 0;

    string mensaje;
     
    /// <summary>
    /// se crea el constructor con dos argumentos que manejara todos los parametros y variables del zombie
    /// el constructor requiere 2 argumentos/parametros un entero llamado daño el cual sera usado en un random.range a la hora de generar el gameobject
    /// y otro llamado nombre el cual sera usado para ser implementado en un metodo que sera utilizado en otros scripts para acceder al nombre del zombie
    /// dentro del constructor la variable string llamada nombre se iguala al parametro string del constructor
    /// la variable entera llamada alea se iguala un randomrange entre 1 y 4 para hacerlo inclusivo 
    /// con el gameobject figura se genera una primitiva de tipo cubo
    /// luego se cambia el nombre del gameobject
    /// luego se generan 3 condicionales tipo if los cuales seran menejados con la variable alea  segun el numero que les corresponda en el rango aleatorio de alea 
    /// se accede al componente renderer y se le asigna un color al objeto
    /// despues se crea una variable de tipo vector 3 llamada posicion la cual sera un referente de posicion en el mundo para el objeto
    /// la variable tipo vector3 se le dan unos valores aleatorios en los ejes x y z y un valor fijo en el eje 
    /// luego el posicion del objeto es igualada a la de la variable tipo vector3
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="daño"></param>
    public Zombie()
    {
        
        
        alea = UnityEngine.Random.Range(1, 4);
       
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

        posicion.x = UnityEngine.Random.Range(-25, 25);

        posicion.y = 1.56f;

        posicion.z = UnityEngine.Random.Range(-35, 30);

        figura.transform.position = posicion;
        
    }
    
    /// <summary>
    /// luego se crea una instancia la cual entregara el mensaje designado en la actividad
    /// </summary>
    /// <returns></returns>
    public string stats()
    {
      if (alea == 1)
      {
        mensaje = "Hola soy" +   " " + "soy un zombie color cyan";
      }
      if(alea == 2)
      {
        mensaje = "Hola soy" +  " " + "soy un zombie color verde";
      }
      if(alea == 3)
      {
        mensaje = "Hola soy" +  " " + "soy un zombie color magenta";
      }
        return mensaje;

    }
}

