using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Cuando el proyectil supere los limites seleccionados se destruirán.
    private float xmax = 300f;
    private float ymax = 300f;
    private float zmax = 300f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xmax)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -xmax)
        {
            Destroy(gameObject);
        }
        if (transform.position.y > ymax)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
        }
        if (transform.position.z > zmax)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -zmax)
        {
            Destroy(gameObject);
        }
    }
}