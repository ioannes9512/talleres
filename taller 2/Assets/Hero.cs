using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    GameObject hero;
    
    void Start()
    {
        hero = gameObject;
        hero.name = "Hero";
        hero.GetComponent<Renderer>().material.color = Color.red;
        hero.AddComponent<Rigidbody>();
        hero.AddComponent<Control>();








    }

    
}
