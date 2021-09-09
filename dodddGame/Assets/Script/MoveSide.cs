using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSide : MonoBehaviour
{

    //public Collider2D leftT;
    //public Collider2D rightT;
    [SerializeField] public GameObject playerPos;
    private bool playerTouchEdge;
    Rigidbody2D playerRb;
    

    void Start()
    {
        playerTouchEdge = false;

        //playerRb = playerPos.GetComponent<Rigidbody2D>();

    }

    
    void Update()
    {
        if (playerTouchEdge == true)
        {
            playerPos.transform.position = new Vector2(-playerPos.transform.position.x, playerPos.transform.position.y);

            playerTouchEdge = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerTouchEdge = true;
           
        }
    }
}
