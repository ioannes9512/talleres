using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using zombies = NPC.enemy;
using citizen = NPC.Ally;
public class Control : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MovY = Input.GetAxisRaw("Vertical");
        float MovX = Input.GetAxisRaw("Horizontal");

        transform.Translate(0f, 0f, MovY * 0.5f);
        transform.Rotate(0f, MovX * 2f, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<zombies.Zombies>())
        {
            zombies.Zombies zombie = collision.collider.GetComponent<zombies.Zombies>();
            Debug.Log("Wrrrr soy un Zombie y quiero comer" + " " + zombie.GetZombiestats().partes);
        }
        if (collision.collider.GetComponent<citizen.Citizen>())
        {
            citizen.Citizen civil = collision.collider.GetComponent<citizen.Citizen>();
            Debug.Log("Hola soy" + civil.statsciv().nombre + " Tengo " + civil.statsciv().edad + "Años");
        }
    }
}
