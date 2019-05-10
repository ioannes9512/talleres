using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using zomboid = NPC.UNDEAD;
using civitas = NPC.Ally;
/// <summary>
/// se crea la clase que contiene las variables a la hora de generar todas las instancias
/// se cretan dos elementos tipo texto par mostrar la cantidad de instancias generadas de cada tipo 
/// se crean dos variables eteras para llevar la cuenta de la cantidad de instancias 
/// se crea un array de gameobjects los cuales contienen una cantidad x de instancias zombies y de citizens
/// se se generar todas las instancias
/// </summary>
public class Creacion : MonoBehaviour
{
    public TextMeshProUGUI cantidadZombies;
    public TextMeshProUGUI cantidadcitizens;
    public int cantidadZombi;
    public int cantidadciv;
    public GameObject[] Zombies,citizens;
    void Start()
    {
        new CrearInstancias();

    }


    /// <summary>
    /// Utilizamos el canvas en escena para mostrar cuantas instancias se han generado en el momento
    /// convertimos los valores enteros a texto y estos textos para ser usados por los textos de interfaz
    /// </summary>
    private void Update()
    {
        Zombies = GameObject.FindGameObjectsWithTag("Zombie");
        citizens = GameObject.FindGameObjectsWithTag("Villager");
        foreach (GameObject item in Zombies)
        {
            cantidadZombi = Zombies.Length;
        }
        foreach (GameObject item in citizens)
        {
            cantidadciv = citizens.Length;
        }

        if(citizens.Length == 0)
        {
            cantidadcitizens.text = 0.ToString();
        }
        else
        {
            cantidadcitizens.text =cantidadciv.ToString();
        }

        cantidadZombies.text = cantidadZombi.ToString();
    }
}
/// <summary>
/// se generan al azar las instancias y se les asigna un componente que va determinado por un rango aleatorio
/// todo esto se aplica sobre la variable local tipo gameobject  
/// </summary>
 class CrearInstancias 
{
    public GameObject recipiente;
    public readonly int minInstancias = Random.Range(5, 16);
    int asignador = 0;
    const int MAX = 26;
    public CrearInstancias()
    {
        for (int i = 0; i < Random.Range(minInstancias,MAX); i++)
        {
            
            if (asignador == 0)
            {
                recipiente = GameObject.CreatePrimitive(PrimitiveType.Cube);
                recipiente.AddComponent<Camera>();
                recipiente.AddComponent<Hero>();
                
                recipiente.AddComponent<Hero.MoverH>();
                recipiente.transform.position = new Vector3(Random.Range(-20, 21), 0, Random.Range(-20, 21));
                asignador += 1;
            }

            int selecionar = Random.Range(asignador, 3);

            if (selecionar == 1)
            {
                recipiente = GameObject.CreatePrimitive(PrimitiveType.Cube);
                recipiente.AddComponent<civitas.Citizen>();
                recipiente.transform.position = new Vector3(Random.Range(-20, 21), 0, Random.Range(-20, 21));
            }
            if (selecionar == 2)
            {
                recipiente = GameObject.CreatePrimitive(PrimitiveType.Cube);
                recipiente.AddComponent<zomboid.Zombie>();
                recipiente.transform.position = new Vector3(Random.Range(-20, 21), 0, Random.Range(-20, 21));
            }
        }
    }
}