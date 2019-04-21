using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NPC
{
    namespace enemy
    {

        public class Zombies : MonoBehaviour
        {
            GameObject Zomb;
            Vector3 Punto;
            Vector3 Giro;

            public enum Colores
            {
              cyan,magenta,verde
            }
            Colores colores;

            public enum Zombstates
            {
              idle,moving,rotating
            }
            Zombstates zombstates;

            public enum bodyparts
            {
                Cerebros,Brazos,Piernas,Riñon,Higado
            }
            public bodyparts gustos;

            public struct Zombiestats
            {
                public Colores color;
                public bodyparts partes;
                public Zombstates estados;

            }

            void Start()
            {
                int asignar = Random.Range(0, 3);
                Zomb = gameObject;
                Zomb.name = "Zombie";
                Zomb.transform.position = new Vector3(Random.Range(-20, 20), 0.2f, Random.Range(-20, 15));
                Zomb.AddComponent<Rigidbody>();
                Zomb.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                Zomb.GetComponent<Rigidbody>().useGravity = false;
                colores = (Colores)Random.Range(0, 3);
                if(colores == Colores.cyan)
                {

                    Zomb.GetComponent<Renderer>().material.color = Color.cyan;

                }
                if (colores == Colores.magenta)
                {
                    Zomb.GetComponent<Renderer>().material.color = Color.magenta;
                }
                if(colores == Colores.verde)
                {
                    Zomb.GetComponent<Renderer>().material.color = Color.green;
                }

                StartCoroutine(Estado());



            }

           
            void Update()
            {
              if(zombstates == Zombstates.idle)
              {
                    Debug.Log("No hay victimas");
              }

              if(zombstates == Zombstates.moving)
              {
                    transform.Translate(Punto * Time.deltaTime * 0.3f);
              }

              if(zombstates == Zombstates.rotating)
              {
                    transform.Rotate(Giro);
              }
            
            }

            public Zombiestats GetZombiestats()
            {
                gustos = (bodyparts)Random.Range(0, 4);
                Zombiestats stats = new Zombiestats();
                if(gustos == bodyparts.Brazos)
                {
                    stats.partes = bodyparts.Brazos;
                    Debug.Log("Warrrrr soy un zombie y quiero comer" + stats.partes);
                }
                if(gustos == bodyparts.Cerebros)
                {
                    stats.partes = bodyparts.Cerebros;
                    Debug.Log("Warrr soy un zombie y quiero comer" + stats.partes);

                }
                if(gustos == bodyparts.Higado)
                {
                    stats.partes = bodyparts.Higado;
                    Debug.Log("Warrr soy un zombie y quiero comer" + stats.partes);

                }
                if(gustos == bodyparts.Piernas)
                {
                    stats.partes = bodyparts.Piernas;
                    Debug.Log("Warrr soy un zombie y quiero comer" + stats.partes);
                }
                if(gustos == bodyparts.Riñon)
                {
                    stats.partes = bodyparts.Riñon;
                    Debug.Log("Warr soy un zombie y quiero comer" + stats.partes);
                }
                return stats;

            }
            public IEnumerator Estado()
            {
                zombstates = (Zombstates)Random.Range(0, 3);

                if(zombstates == Zombstates.idle)
                {

                }
                if(zombstates == Zombstates.moving)
                {
                    Punto = new Vector3(Random.Range(-22, 20), 0.2f, Random.Range(-20, 20));
                    yield return null;
                }

                if(zombstates == Zombstates.rotating)
                {
                    Giro = new Vector3(0f, 1f, 0f);
                    yield return null;
                }

                yield return new WaitForSeconds(3f);
                yield return Estado();

            }
        }
       
    }

    namespace Ally
    {
        public class Citizen : MonoBehaviour
        {
            GameObject Civil;
            public enum Nombres
            {
                pablo, hilario, sergio, ramon, socorro, auxilio, jose, maria, luisa, nicanor, neptalí, eulalia, jacinta, ufano, candido, teodosia,
                castulo, gervasia, eufemio, higinio
            }

            public struct Citizenstats
            {

                public int edad;
                public string nombre;
            }

            private void Start()
            {
                Civil = gameObject;
                Civil.GetComponent<Renderer>().material.color = Color.blue;
                Civil.name = "Citizen";
                Civil.transform.position = new Vector3(Random.Range(-25, 20), 0.1f, Random.Range(-20, 25));
                Civil.AddComponent<Rigidbody>();
                Civil.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
                Civil.GetComponent<Rigidbody>().useGravity = false;
            }

            public Citizenstats statsciv()
            {
                Citizenstats stats = new Citizenstats();
                stats.nombre = ((Nombres)Random.Range(0,21)).ToString();
                stats.nombre = ((Nombres)Random.Range(0, 21)).ToString();
                return stats;
 


            }





























        }




























    }


























}
