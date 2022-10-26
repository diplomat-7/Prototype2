using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xrange = 10.0f;
    public GameObject projectilePrefab;

    //public float leftBoundary = -10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    //   // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xrange) { transform.position = new Vector3(-xrange, transform.position.y, transform.position.z); }
        if (transform.position.x > xrange) { transform.position = new Vector3(xrange, transform.position.y, transform.position.z); }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //if(transform.position.x < -10) { transform.position = new Vector3(-10, transform.position.y, transform.position.z); }
    }
}
