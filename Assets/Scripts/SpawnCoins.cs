using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    //Limites de aparición de los recolectables
    private float xRange = 100f;
    private float yRange = 100f;
    private float zRange = 100f;
    private float lowRange = 50f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-xRange, xRange), Random.Range(lowRange, yRange), Random.Range(-zRange, zRange));
    }

    // Update is called once per frame
    void Update()
    {

    }
}