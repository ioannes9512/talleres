using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using zombies = NPC.enemy;//con esto se accede al name space npc y a la clase llamada enemy contenida dentro del namespace npc
using citizen = NPC.Ally;//accede al namespace npc y a la clase ally 
public class Control : MonoBehaviour
{
    
    void Update()
    {
        float MovY = Input.GetAxisRaw("Vertical");
        float MovX = Input.GetAxisRaw("Horizontal");

        transform.Translate(0f, 0f, MovY * 0.5f);
        transform.Rotate(0f, MovX * 2f, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<zombies.Zombies>())//con esto se pregunta si el objeto con el que collisiono posee el componente zombies el cual accede al namespace npc,especificamente a la clase zombies
        {
            zombies.Zombies zombie = collision.collider.GetComponent<zombies.Zombies>();//se crea una variable la cual se iguala a la colision para almacenarla
            Debug.Log("Wrrrr soy un Zombie y quiero comer" + " " + zombie.GetZombiestats().partes);//con esto se imprime un mensaje en la consola que lleva tambian las estadisticas del zombie y sus gustos
        }
        if (collision.collider.GetComponent<citizen.Citizen>())// con esto se asegura de preguntar si el objeto con el que colisiona posee el componente citizen el cual accede a la clase citizen contenida en el namespace ally
        {
            citizen.Citizen civil = collision.collider.GetComponent<citizen.Citizen>();//se crea una variable que almacena la colision
            Debug.Log("Hola soy" + " " + civil.statsciv().nombre + " Tengo " + civil.statsciv().edad + "Años");//se impirime en la consola un mensaje con los datos del ciudadano que accede a la estructura con los datso del ciudadano 
        }
    }
}
