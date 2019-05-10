using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace NPC// este es el namespace que contiene as su vez otros dos namespaces cada uno con una clase unica
{
    /// <summary>
    /// este name space contiene la clase zombie que es el enemigo
    /// </summary>
    namespace enemy//este contiene todo lo relacionado con la clase zombie
    {
        /// <summary>
        /// esta clase contiene todo lo realcionado con la clase zombie y su funcionamiento
        /// se genera un game object al cual se le añaden varios componenetes
        /// se crea un vector3 que se encarga del moviemiento y desplazamiento del zombie
        /// se crea un vector3 que se encarga de la rotacion del zombie
        /// </summary>
        public class Zombies : MonoBehaviour
        {
            GameObject Zomb;
            Vector3 Punto;
            Vector3 Giro;
            /// <summary>
            /// se crea un enum con tres elementos que se encargan de modificar el material del objeto para asignarle un color
            /// se crea una variable des mismo tipo que la que contiene el enum para asignar los colores luego
            /// se crea un enum de 3 elementos que se usan para determinar el comportamiento del zombie es decir sus estados
            /// se crea una variable de tipo zombstates la cual sera usada para determinar el comportamiento del zombi
            /// este enum contiene 5 elementos que seran utilizados para designar los gustos del zombie escogidos entre los 5 items que representan partes del cuerpo
            /// se crea una variable de tipo gustos la cual sera usada para determinar que es lo que quiere comer el zombi
            /// esta estructura de datos contiene todas las variales designadas del tipo enum
            /// </summary>
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
            /// <summary>
            /// se crea una variable entera con un rango aleatorio
            /// se iguala la variable zom a un gameobjetc
            ///  cambia el nombre del objetos una vez creado
            ///  crea el objeto en una en la posicion aleatoria
            ///  añade un rigidbody al objeto
            ///  se accede a las constraits del rigidbody del objeto para restringir el comportamiento del rigidbody
            ///  se deshabilita la gravedad del rigidbody
            ///  la variable de tipo colores del enum es iguala a un randomrange el el cual operara en base a los elementos del 
            ///  enum en este caso el los tres items usando tres para que sea inclusivo
            ///  inicia la corrutina encargada de gestionar los estados del zombie
            /// </summary>
            void Start()
            {
                int asignar = Random.Range(0, 3);
                Zomb = gameObject; 
                Zomb.name = "Zombie";
                Zomb.transform.position = new Vector3(Random.Range(-20, 20), 1, Random.Range(-20, 15));
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
              //estas lines se encargar de asignar un comportamiento con sus respecticas acciones a cada variable del enum de estados
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

            public Zombiestats GetZombiestats()//esta es una invocacion de la estructura que se encarga de operar todas las estadisticas del zombie
            {
                gustos = (bodyparts)Random.Range(0, 4);//esn esta linea se utiliza la variable gustos que es una variable de tipo bodyparts que es el enum y este se iguala a un random range el cual selecciona entre los 5 elementos del enum
                Zombiestats stats = new Zombiestats();
                if(gustos == bodyparts.Brazos)//luego de que se le asigna uno de los 5 items del enum y en funcion de que parte escoja este imprimira in mensaje en la consola con el elemento asignado
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
                return stats;//entrega toda la informacion contenida dentro de esta estructura

            }
            public IEnumerator Estado()//esta corrutina se encarga de manejar los cmportamientos del zombie en funcion del que este activo en el momento el cual estara determinado por una asignacion random de la variable zombstates
            {
                zombstates = (Zombstates)Random.Range(0, 3);//esta asignacion de la variable zombstates con un random range selecciona en un rango al azar de 0 a 3 entre los tres elementos del enum zombstates

                if(zombstates == Zombstates.idle)
                {

                }
                if(zombstates == Zombstates.moving)
                {
                    Punto = new Vector3(Random.Range(-22, 20), 0.5f, Random.Range(-20, 20));// en esta parte de la corutina el movimiento del zombie 
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

    namespace Ally// este namespace se encarga de todo lo relacionado con la clase citizen
    {
        public class Citizen : MonoBehaviour
        {
            GameObject Civil;
            public enum Nombres//se crea un enum donde cada elemento pertenece a los nombres que se le daran mas adelande en los stats
            {
                pablo, hilario, sergio, ramon, socorro, auxilio, jose, maria, luisa, nicanor, neptalí, eulalia, jacinta, ufano, candido, teodosia,
                castulo, gervasia, eufemio, higinio
            }

            public struct Citizenstats//estructura que contiene la informacion del ciudadano
            {

                public int edad;
                public string nombre;
            }

            private void Start()
            {
                Civil = gameObject;//gameobject que sera el ciudadano
                Civil.GetComponent<Renderer>().material.color = Color.blue;//con esto se le asigna un color al ciudadano en este caso el color azul
                Civil.name = "Citizen";//se le asigna un nombre al game object ciudadano
                Civil.transform.position = new Vector3(Random.Range(-25, 20), 1f, Random.Range(-20, 25));//con esta lina hace que una vez creado el objeto su posicion en el mundo sera aleatoria entre un rango especifico
                Civil.AddComponent<Rigidbody>();//se le da un rigidbody al objeto
                Civil.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;// se accede al rigidbody del objeto para ponerle los constraits
                Civil.GetComponent<Rigidbody>().useGravity = false;// se accede al rigidbody del objeto para deshabilitar la gravedad del mismo
            }

            public Citizenstats statsciv()//se hace una invocacion de la estructura la cual manejara todo lo relacionado con los datos del ciudadano
            {
                Citizenstats stats = new Citizenstats();//se crea una nueva instancia para operar con ella
                stats.nombre = ((Nombres)Random.Range(0,21)).ToString();//con esto se accede al enum que contiene los nombres se le asigna al azar un nombre entre los 21 items del enum y luego se conviertes en un elemento de tipo texto
                stats.edad = Random.Range(15,100);//en esta linea se accede a la variable entera edad que esta dentro de la estructura y se le da un rango al azar para que entregue la edad del ciudadano
                return stats;//este entrega todos los datos contenidos en la estructura;
 


            }



        }




    }

}
