using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Zombie zomboid;
    Vector3 control;
    Rigidbody body;
    float velocidad = 8f;
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float movx = Input.GetAxisRaw("Horizontal");
        float movy = Input.GetAxisRaw("Vertical");
        Direccion(movx, movy);
        Girar();
        



    }
    public void Direccion(float prh, float prv)
    {
        control.Set(prh, 0, prv);
        control = control.normalized * Time.deltaTime * velocidad;
        body.MovePosition(transform.position + control);
    }

    public void Girar()
    {
        Ray targetdir = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit Hitpoint;

        if(Physics.Raycast(targetdir, out Hitpoint))
        {
            Vector3 movetoreference = Hitpoint.point - transform.position;
            movetoreference.y = 0f;

            Quaternion Setnewrotation = Quaternion.LookRotation(movetoreference);
            body.MoveRotation(Setnewrotation);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<Zombie>())
        {
            Zombie zombie = collision.collider.GetComponent<Zombie>();
            Debug.Log(" Warrrrrr soy un zombie y quiero" + zombie.Getzombietats().partes);

        }

        if (collision.collider.GetComponent<Citizen>())
        {
            Citizen civitas = collision.collider.GetComponent<Citizen>();
            Debug.Log("Hola soy:" + civitas.getcitizenstats().nombre + civitas.getcitizenstats().edad + "Años");
        }
    }

   
}
