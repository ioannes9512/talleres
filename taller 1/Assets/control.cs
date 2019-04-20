using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    Rigidbody herue;
   
    // Start is called before the first frame update
    void Start()
    {
        herue = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxisRaw("Horizontal");
        float Y = Input.GetAxisRaw("Vertical");
        transform.Translate(0f, 0f, Y * 0.7f);
        transform.Rotate(0f, X * 3f, 0f);
    }
}
