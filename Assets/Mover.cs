using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * speed;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
