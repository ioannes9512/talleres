using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// clase encargada de configurar todo lo relacionado al heroe solo se crea un gameobject al cual se le añadiran componentes
/// </summary>
public class Hero 
{
    GameObject hero;


   
    /// <summary>
    /// se crea un constructor 
    /// con el game object creado en la clase se genera una primitiva de tipo cubo 
    /// luego se crea una variable tipo vector 3 para referenciar la posicion del objeto en el mundo
    /// se cambia el nombre del objeto
    /// luego añade el componente control es decir todo lo contenido en el script control el cual contiene todo lo relacionado con el movimiento del heroe 
    /// luego se accede al renderer del objeto para cambiar el color del objeto
    /// luego se añade un rigidbody al objeto
    /// despues se accede a las constraits del rigidbody del objeto para frezear
    /// se añade un camara del objeto 
    /// y luego se accede al rigidbody del objeto para deshabilitar la gravedad del objeto
    /// </summary>
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
