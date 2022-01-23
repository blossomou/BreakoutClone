using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = 20f; //20 units per second
    private Rigidbody rigidbody;
    private Vector3 velocity;

    
    // Start is called before the first frame update
    void Start()
    {
        
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = Vector3.down * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        
        rigidbody.velocity = rigidbody.velocity.normalized * speed; //whatever the speed the ball is moving, it will take the value to 1 using normalized
        velocity = rigidbody.velocity;
    }
     private void OnCollisionEnter(Collision collision) {
        rigidbody.velocity = Vector3.Reflect(velocity, collision.contacts[0].normal); //normal is the first point in the collision of perpendicular impact of itself
    }
}
