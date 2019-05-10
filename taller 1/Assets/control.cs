using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    /*Rigidbody herue;
   
    // Start is called before the first frame update
    void Start()
    {
        herue = GetComponent<Rigidbody>();
    }*/

    // Update is called once per frame
    /// <summary>
    /// se crean dos variables tipo float y luego se igualan a un axis uno vertical y otro horizontal
    /// se modofica  la rotacion y el translate y poniendo en sus parametros los axis declarados anteriormente 
    /// </summary>
    void Update()
    {
        float X = Input.GetAxisRaw("Horizontal");
        float Y = Input.GetAxisRaw("Vertical");
        transform.Translate(0f, 0f, Y * 0.7f);
        transform.Rotate(0f, X * 3f, 0f);
    }
}
