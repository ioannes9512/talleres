using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class citizen : MonoBehaviour
{
    
    // Start is called before the first frame update
    /// <summary>
    /// se crea un array con una lista de nombres 
    /// luego se crean variables con un random.range que seran asignadas luego dentro del ciclo for
    /// y en funcion de lo que le corresponda crea una cantidad x en el rango establecida una instancia de tipo zombie o aldeano y luego imprime por consola 
    /// los mensajes estipulados en la actividad
    /// y crea una instancia tipo zombie
    /// </summary>
    void Start()
    {
        


        string[] nombrecitizen =
        {
           "pablo","sergio","javier","david","carlos","damian","silvia","raquel","elena","boris","anibal","claudia",
           "poncio","marina","mariela","pedro","paula","marcos","thomas","ediberto"

        };
        int asignar = UnityEngine.Random.Range(1, 5);

        for(int i = 0; i < asignar; i++)
        {

            Zombie zomb = new Zombie();
            Debug.Log(zomb.stats());

        }
        int asignar2 = UnityEngine.Random.Range(1, 15);
        for(int j = 0;j < asignar2; j++)
        {
            Ciudadano civ = new Ciudadano(nombrecitizen[UnityEngine.Random.Range(0, 20)], UnityEngine.Random.Range(15, 100));
            Debug.Log(civ.Stats());
        }
        Hero hero = new Hero();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
