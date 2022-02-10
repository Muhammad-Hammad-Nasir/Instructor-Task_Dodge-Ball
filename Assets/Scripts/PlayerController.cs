using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontal;
    private float speed = 20;
    private float limitMove = 10;

    void Update()
    {
        PlayerMovement();
        Boundary();
    }

    void PlayerMovement()
    {
        horizontal = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
    }

    void Boundary()
    {
        if (transform.position.x < -limitMove)
        {
            transform.position = new Vector3(-limitMove, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > limitMove)
        {
            transform.position = new Vector3(limitMove, transform.position.y, transform.position.z);
        }
    }
}
