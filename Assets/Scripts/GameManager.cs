using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public CollisionDetection collision;
    public GameObject enemyPrefab;
    public bool isCollision;

    private Vector3[] spawnPos;
    private Vector3 spawnPos1;
    private Vector3 spawnPos2;
    private Vector3 spawnPos3;
    private Vector3 spawnPos4;
    private Vector3 spawnPos5;

    private float yLimit = 16f;
    private float startDelay = 2.0f;
    private float spawnInterval = 2.5f;
    private int enemies = 5;
    private int j = 0;

    void Start()
    {
        spawnPos1 = new Vector3(0, yLimit, 0);
        spawnPos2 = new Vector3(4.5f, yLimit, 0);
        spawnPos3 = new Vector3(9, yLimit, 0);
        spawnPos4 = new Vector3(-4.5f, yLimit, 0);
        spawnPos5 = new Vector3(-9, yLimit, 0);
        spawnPos = new Vector3[5] { spawnPos1, spawnPos2, spawnPos3, spawnPos4, spawnPos5 };
        InvokeRepeating("SpawnEnemy", startDelay, spawnInterval);
    }

    void Update()
    {
        CollisionDetect();
    }

    void SpawnEnemy()
    {
        int randomNum = Random.Range(0, enemies);

        for (int i = 0; i < enemies; i++)
        {
            if (i != randomNum)
            {
                Instantiate(enemyPrefab, spawnPos[i], this.transform.rotation);
            }
        }
    }

    void CollisionDetect()
    {
        if (isCollision && j == 0)
        {
            CancelInvoke("SpawnEnemy");
            Debug.Log("GameOver");
            j++;
        }
    }
}
