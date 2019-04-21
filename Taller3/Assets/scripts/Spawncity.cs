using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zombies = NPC.enemy;
using citizen = NPC.Ally;
public class Spawncity : MonoBehaviour
{
    GameObject npc;
    GameObject hero;
    int cantidadzombies;
    int cantidadcitizens;
    public Text cantzombies;
    public Text cantcitizens;
    public readonly int npcminimos = Info.minimumobjs;
    const int npcsmaximos = Info.maxobjs;
    
    void Start()
    {
        hero = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        hero.AddComponent<Hero>();

        for(int i = npcminimos; i < npcsmaximos; i++)
        {
            int asignar = Random.Range(0, 2);
            npc = GameObject.CreatePrimitive(PrimitiveType.Cube);
            if(asignar == 0)
            {
                npc.AddComponent<Zombies.Zombies>();
            }
            if(asignar == 1)
            {
                npc.AddComponent<citizen.Citizen>();
            }

        }
        StartCoroutine(CantidadNPC());
    }

    
    void Update()
    {
        
    }
    public void stop()
    {
        StopCoroutine(CantidadNPC());
    }

    IEnumerator CantidadNPC()
    {
        Zombies.Zombies[] zombi = FindObjectsOfType<Zombies.Zombies>();
        foreach(Zombies.Zombies zomb in zombi)
        {
            cantidadzombies++;
        }
        cantzombies.text = "Numero de enemigos :" + cantidadzombies.ToString();
        citizen.Citizen[] civiles = FindObjectsOfType<citizen.Citizen>();
        foreach(citizen.Citizen civ in civiles)
        {
            cantidadcitizens++;
        }
        cantcitizens.text = "Numero de civiles:" + cantidadcitizens.ToString();
        yield return new WaitForSeconds(0.3f);
    }



}
