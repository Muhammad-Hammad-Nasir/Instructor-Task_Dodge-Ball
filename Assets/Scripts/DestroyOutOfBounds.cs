using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float yLimit = -2f;

    void Update()
    {
        DestroyEnemy();
    }

    void DestroyEnemy()
    {
        if (transform.position.y < yLimit)
        {
            Destroy(gameObject);
        }
    }
}
