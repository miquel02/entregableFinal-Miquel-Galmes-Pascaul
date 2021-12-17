using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 30.0f;
    public float turnSpeed = 5f;
    public float horizontalInput;
    public float verticalInput;
    private float xmax = 200f;
    private float ymax = 200f;
    private float zmax = 200f;
    public GameObject proyectil;
    private int quantityCoins = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Posicion de inicio
        transform.position = new Vector3(0, 100, 0);
        Debug.Log(quantityCoins);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Rotación Vertical del player
        transform.Rotate(Vector3.left * speed * Time.deltaTime * verticalInput);

        //Rotación Horizontal del player
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

        //Limites de la pantalla
        if (transform.position.x > xmax)
        {
            transform.position = new Vector3(xmax, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -xmax)
        {
            transform.position = new Vector3(-xmax, transform.position.y, transform.position.z);
        }
        if (transform.position.y > ymax)
        {
            transform.position = new Vector3(transform.position.x, ymax, transform.position.z);
        }
        if (transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }
        if (transform.position.z > zmax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zmax);
        }

        if (transform.position.z < -zmax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zmax);
        }

        //Aparición del proyectil
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            Instantiate(proyectil, transform.position, gameObject.transform.rotation);
        }

    }
    private void OnTriggerEnter(Collider otherCollider)
    {
        //Cuando se recojan 10 monedas el juego finaliza
        if (otherCollider.gameObject.CompareTag("moneda"))
        {
            quantityCoins += 1;
            Destroy(otherCollider.gameObject);
            Debug.Log($"Tienes {quantityCoins} monedas");
            if (quantityCoins == 10)
            {
                Time.timeScale = 0;
                Debug.Log("Lo logradaste, Has Ganado!");
            }
        }
    }
}