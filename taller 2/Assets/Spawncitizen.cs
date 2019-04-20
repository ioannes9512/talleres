using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

   
    void Update()
    {
        
    }
}
