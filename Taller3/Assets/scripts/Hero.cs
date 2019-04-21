using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    GameObject hero;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        
        hero = gameObject;
        hero.name = "Hero";
        hero.GetComponentInChildren<Renderer>().material.color = Color.red;
        hero.AddComponent<Rigidbody>();
        hero.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        hero.GetComponent<Rigidbody>().useGravity = false;
        hero.transform.position = new Vector3(0f, 1f, 0f);
        hero.AddComponent<Control>();
        hero.AddComponent<Camera>();








    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
