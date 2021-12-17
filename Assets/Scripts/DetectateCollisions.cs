using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectateCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (gameObject.CompareTag("obstacle") && otherCollider.gameObject.CompareTag("Player"))
        {
            Debug.Log($"GAME OVER");
            Time.timeScale = 0;
        }
        if (gameObject.CompareTag("obstacle") && otherCollider.gameObject.CompareTag("proyectil"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
        }
    }

}