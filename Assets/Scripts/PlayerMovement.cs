using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float forwardSpeed = 2000f;
    public float sidewaysForce = 500f;

    public Text scoreText;

    public GameManager gameManager;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        scoreText.text = transform.position.z.ToString("0");

        if(rb.position.y < -1f)
        {
            gameManager.EndGame();
        }
    }
}
