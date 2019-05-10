using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zombies = NPC.enemy;//accede al namespace enemey contenido a su vez dentro del namespace npc
using citizen = NPC.Ally;//accede al namespace ally contenido dentro del namespace npc
public class Spawncity : MonoBehaviour
{
    
    int cantidadzombies;//variable entera que llevara la cuenta de las instancias zombie generadas
    int cantidadcitizens;//variable entera que llevara la cuenta de las instacias ciudadano generadas
    public Text cantzombies;//elemento de interfaz el cual mostrara la cantidad de istancias zombie generadas
    public Text cantcitizens;//elemento de interfaz el cual mostrara la cantidad de instancias de ciudadanos generados
    
    
    void Start()
    {
        npcinfo crear = new npcinfo();// se crea una nueva instancia de la clase npcinfo
        StartCoroutine(CantidadNPC());//se inicia la corutina que lleva la cuenta de los npcs
    }

    
    void Update()
    {
        
    }
    public void stop()
    {
        StopCoroutine(CantidadNPC());// se detiene la corutina
    }
    /// <summary>
    /// esta corutina se encarga de buscar todos los objetos del tipo especificado
    /// y por cada objeto encontrado suma uno a la variable entera esta a su vez se convierte en un texto de interfaz 
    /// que sirve par mostrar en pantallas la cantidad de instancias generadas
    /// </summary>
    /// <returns></returns>
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
/// <summary>
/// se crea una nueva clase donde se declaran 
/// las variables readonly constante la con un rango aleatorio y la variable constante que determinara la cantidad de npcs maximos
/// junto con 2 gameobjecta los cuales le seran asignado los datos del heroe y del npc tanto zombie como ciudadano
/// </summary>
public class npcinfo
{
    public readonly int mininstancias = Random.Range(5, 16);
    const int Maxinstancias = 25;
    GameObject npc;
    GameObject Hero;

    public npcinfo()
    {
        Hero = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Hero.AddComponent<Hero>();
        for(int i = 0; i <= Random.Range(mininstancias,Maxinstancias); i++)
        {
            npc = GameObject.CreatePrimitive(PrimitiveType.Cube);
            int alea = Random.Range(0, 2);
            if(alea == 0)
            {
                npc.AddComponent<Zombies.Zombies>();
                
            }
            if(alea == 1)
            {
                npc.AddComponent<citizen.Citizen>();
            }
        } 
    }





}