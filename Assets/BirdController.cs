using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector2(speed, rigidbody.velocity.y);
    }
}
