using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// se crean dos gameobject uno que al que se le asignara un rol dependientdo de lo que le corresponda
/// y un heroe al cuel estara representado por una primitiva 
/// y al cual se le añade el componente zombie es decir el script zombie 
/// dentro del ciclo for se pone el limite de instancias acordadas en la actividad 
/// y tembien una  variable de tipo entero con un random range para poder asignar los roles
/// junto con una primitiva que representara al npc
/// se crean dos condicionales if en funcion del numero asigando se le añade el componente zombie o citizen
/// </summary>
public class Spawncitizen : MonoBehaviour
{
    GameObject npc;
    GameObject hero;
    
    void Start()
    {
        hero = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hero.AddComponent<Hero>();

        for(int i = 0; i < 11; i++)
        {
            int escoger = Random.Range(0, 2);
            npc = GameObject.CreatePrimitive(PrimitiveType.Cube);
            if(escoger == 0)
            {
                npc.AddComponent<Zombie>();
            }

            if(escoger == 1)
            {
                npc.AddComponent<Citizen>();
            }

        }

    }
}
