using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement playerMove;

    public GameManager gameManager;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            playerMove.enabled = false;
            gameManager.EndGame();
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Finish")
        {
            gameManager.GameWon();
        }
    }
}
