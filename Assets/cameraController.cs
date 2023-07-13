using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform bird;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = bird.position - transform.position;
        print(offset);
        print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(bird.position.x - offset.x, transform.position.y, transform.position.z);
    }
}
