using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    GameObject zombie;
    string mensaje;
    float distancia;
    bool activado = true;
    int estado;
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
    void Update()
    {
       if(estadoszombi == Estados.idle)
       {
            Debug.Log("NO veo victimas");
       }

       if(estadoszombi == Estados.moving)
       {
            transform.Translate(punto * Time.deltaTime * 0.4f);
       }

    }

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
