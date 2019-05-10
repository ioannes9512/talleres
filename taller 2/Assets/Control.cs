using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// se crean 2 axis para dar moviento al heroe
/// </summary>
public class Control : MonoBehaviour
{
    void Update()
    {
        float MovX = Input.GetAxisRaw("Horizontal");
        float MovY = Input.GetAxisRaw("Vertical");
        transform.Translate(0f, 0f, MovY * 0.5f);
        transform.Rotate(0f, MovX * 2f, 0);



    }
    

    
    /// <summary>
    /// se genera una collision con 2 condicionales para iprimir por consola los datos del objeto con el que colisiona
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Zombie>())
        {
            Zombie zombie = collision.collider.GetComponent<Zombie>();
            Debug.Log(" Warrrrrr soy un zombie y quiero comer "+" "+ zombie.Getzombietats().partes);

        }

        if (collision.collider.GetComponent<Citizen>())
        {
            Citizen civitas = collision.collider.GetComponent<Citizen>();
            Debug.Log("Hola soy:" + civitas.getcitizenstats().nombre +"y tengo"+ civitas.getcitizenstats().edad + "Años");
        }
    }

   
}
