using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class citizen : MonoBehaviour
{
    public float moveX;
    public float moveY;
    // Start is called before the first frame update
    void Start()
    {
        string[] Nombrezombie =
        {
           "elulalia","socorro","jose","antonio","pepe","saul"
        };

        string[] nombrecitizen =
        {
           "pablo","sergio","javier","david","carlos","damian","silvia","raquel","elena","boris","anibal","claudia",
           "poncio","marina","mariela","pedro","paula","marcos","thomas","ediberto"

        };
        int asignar = UnityEngine.Random.Range(1, 5);

        for(int i = 0; i < asignar; i++)
        {

            zombie zomb = new zombie(Nombrezombie[i], Random.Range(40, 98));
            Debug.Log(zomb.stats());

        }
        int asignar2 = UnityEngine.Random.Range(1, 6);
        for(int j = 0;j < asignar2; j++)
        {
           spawncitizen civ = new spawncitizen(nombrecitizen[UnityEngine.Random.Range(0, 20)], UnityEngine.Random.Range(15, 100));
            Debug.Log(civ.Stats());
        }
        Hero hero = new Hero();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
