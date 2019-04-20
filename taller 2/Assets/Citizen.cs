using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Citizen : MonoBehaviour
{
    string mensaje;
    int edad;
    string Nombres;
    public enum nombres
    {
      pablo,hilario,sergio,ramon,socorro,auxilio,jose,maria,luisa,nicanor,neptalí,eulalia,jacinta,ufano,candido,teodosia,
      castulo,gervasia,eufemio,higinio

    }
    public struct Stats
    {
        public int edad;
        public string nombre;
    }
    GameObject citizen;
    void Start()
    {
        citizen = gameObject;
        citizen.GetComponent<Renderer>().material.color = Color.yellow;
        citizen.name = "Citizen";
        Nombres = ((nombres)Random.Range(0, 20)).ToString();
        edad = Random.Range(15, 100);
        citizen.transform.position = new Vector3(Random.Range(-25, 20), 0.4f, Random.Range(-20, 20));
        citizen.AddComponent<Rigidbody>();

    }

    public Stats getcitizenstats()
    {
        Stats stats = new Stats();
        stats.edad = edad;
        stats.nombre = Nombres;
        return stats;     


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
