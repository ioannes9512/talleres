using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// se declara una variable de tipo gameobject con la cual se manejara al zombie
/// se declara una variable tipo string llamada mensaje con la cual se entregara el mensaje estipulado en la actividad
/// se declara una variable de tipo booleano la cual controlara la corutina
/// se declara una variable de tipo vector3 
/// se crea un enum llamada estadoszombi la cual contiene dos elementos que corresponden al estado del zombie
/// se crea una enum llamado partes el cual contiene 5 elementos que corresponden a las partes que el zombie desa comer
/// se crea una estructura llamada zombiestats la cual contiene una variable del tipo del enum bodyparts y una referecia de color
/// </summary>
public class Zombie : MonoBehaviour
{
    GameObject zombie;
    string mensaje;
    float distancia;
    bool activado = true;
    Vector3 punto;

    public enum Estados
    {
        idle,moving
    }
    Estados estadoszombi;

    public enum bodypart
    {
      cerebros,brazo,pierna,higado,riñon
    }

    bodypart partes;
    public struct Zombistats
    {
        public Color Color;
        public bodypart partes;
    }
   /// <summary>
   /// se hace la afirmacion del gameobject 
   /// se crea una variable de tipo int a la cual se le da un valor random
   /// luego se crean 3 condicionales if utilzando el valor  asignado de la variable entera declarada anteriormente en funcion del numero que le correponde
   /// accede al material del objeto y cambia el color por uno de los 3 mencionados en la actividad
   /// luego se iguala la posicion del gameobject a un nuevo vector 3 el cual sera el el rango en el cual podra moverse el objeto
   /// cambia el nombre del objeto
   /// luego se le añade un rigidbody al objeto
   /// despues se usa el booleano para activar y desactivar la corutina teniendo en cuenta el estado de la variable booleana
   /// </summary>
    void Start()
    {
        zombie = gameObject;
        int selectcolor = Random.Range(0, 3);
        if(selectcolor == 0)
        {
            zombie.GetComponent<Renderer>().material.color = Color.cyan;
        }
        if(selectcolor == 1)
        {
            zombie.GetComponent<Renderer>().material.color = Color.green;
        }
        if(selectcolor == 2)
        {
            zombie.GetComponent<Renderer>().material.color = Color.magenta;
        }
        zombie.transform.position = new Vector3(Random.Range(-15, 25), 0.4f, Random.Range(-25, 26));
        zombie.name = "Zombie";
        zombie.AddComponent<Rigidbody>();

        if (activado)
        {
            StartCoroutine(Estadoszomb());
        }
        else if(activado == false)
        {
            StopCoroutine(Estadoszomb());
        }
    }
    /// <summary>
    /// se crea un constructor que maneja los gustos del zombie con una serie de condicionales
    /// dentro del constructor se crea una nueva instancia de si mismo
    /// y se crea una variable entera local para ser usada con un rango aleatorio dentro de los condicionales
    /// dentro de cada condicional la nueva istancia creada se iguala a cada parte del enum que contiene los gustos del zombie
    /// se imprime el mensaje estipulado dentro de la actividad 
    /// se retorna los datos contenidos en esta instancia
    /// </summary>
    /// <returns></returns>
    public Zombistats Getzombietats()
    {
        Zombistats stats = new Zombistats();
        int parte = Random.Range(0, 4);

        if(parte == 0)
        {
            stats.partes = bodypart.brazo;
            mensaje = "Warrrrr soy un Zombie y quiero comer " + stats.partes;
        }
        if(parte == 1)
        {
            stats.partes = bodypart.cerebros;
            mensaje = "Warrrrrr soy un Zombie y quiero comer" + stats.partes;
        }
        if(parte == 2)
        {
            stats.partes = bodypart.higado;
            mensaje = "Warrrrr soy un Zombie y quiero comer" + stats.partes;
        }
        if(parte == 3)
        {
            stats.partes = bodypart.pierna;
            mensaje = "Warrrrr soy un Zombie y quiero comer" + stats.partes;

        }
        if(parte == 4)
        {
            stats.partes = bodypart.riñon;
            mensaje = "Warrrr soy un Zombie y quiero comer" + stats.partes;
    
        }
        return stats;

    }
    /// <summary>
    /// en estos condicionales se imprime un mensaje o se traslada el objeto en funcion del estado en que se encuentre
    /// </summary>
    void Update()
    {
       if(estadoszombi == Estados.idle)
       {
            Debug.Log("NO veo victimas");
       }

       if(estadoszombi == Estados.moving)
       {
            Debug.Log("am moving");
            transform.Translate(punto * Time.deltaTime * 0.4f);
       }

    }
    /// <summary>
    /// se crea una corutina que controla los estados del zombie 
    /// dentro de la corutina se crea una nueva instancia del enum junto con una rango aleatorio el cual asigna un comportamiento al azar
    /// se crea un condicional para cuando el estado del sea moving se cree una nueva instancia de la variable tipo vector 3 cuyos valores seran asignados aleatoriamente
    /// la corrutina se ejecutara cada 5 segundos y devolvera el estado en el que se encuentre  
    /// </summary>
    /// <returns></returns>
    public IEnumerator Estadoszomb()
    {
        estadoszombi = (Estados)Random.Range(0, 2);

        if (estadoszombi == Estados.moving)
        {
            punto = new Vector3(Random.Range(-15, 15), 0f, Random.Range(-15, 15));
            yield return null;
        }



        yield return new WaitForSeconds(5f);
        yield return Estadoszomb();


    }
}
