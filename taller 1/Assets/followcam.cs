using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcam : MonoBehaviour
{
    public Transform follow;
    public float movimiento = 4.9f;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - follow.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distancia = follow.position + offset;
        transform.position = Vector3.Lerp(transform.position, distancia, movimiento * Time.deltaTime);
    }
}
