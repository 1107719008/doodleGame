using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    float movement = 0f;
    public float movementSpeed = 10f;

    [SerializeField] private float EdgeR = 2;
    [SerializeField] private float EdgeL = -2;

    Rigidbody2D rb;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal")*movementSpeed;

    }
    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "bottom")
        {
            FindObjectOfType<GameManager>().Invoke("EndGame", 0.5f);
        }
    }
}
