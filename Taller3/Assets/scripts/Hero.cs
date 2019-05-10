using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// se crea la clase encargada de gestionar todo lo relacionado con el heroe
/// se declaran 2 variables una de tipo gameobject que sera la que dara cuerpo al heroe
/// y otroa de tipo vector3 la cual sera el referente de posicion par el heroe
/// </summary>
public class Hero : MonoBehaviour
{
    GameObject hero;
    
    /// <summary>
    /// se cambia el nombre del casteo
    /// se cambia el color del objeto por medio del acceso al componente renderer
    /// se añade un rigidbody al objeto
    /// se accede al rigidbody del objeto par habilitar las constraits
    /// se accede al rigidbody del objeto par deshabilitar la gravedad de este
    /// se crea el objeto en una posicion determinada
    /// se añade el el componente control el es decir todo lo contenido en el script de control
    /// se añade una camara al objeto
    /// 
    /// </summary>
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
    
}
