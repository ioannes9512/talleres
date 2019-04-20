using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero 
{
    GameObject hero;


   

    public Hero()
    {
        hero = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Vector3 Posicion = new Vector3(0, 1.1f, 0);
        hero.transform.position = Posicion;
        hero.name = "Heroe";
        hero.AddComponent<control>();
        hero.GetComponent<Renderer>().material.color = Color.blue;
        hero.AddComponent<Rigidbody>();
        hero.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        hero.AddComponent<Camera>();
        hero.GetComponent<Rigidbody>().useGravity = false;
    }


















}
