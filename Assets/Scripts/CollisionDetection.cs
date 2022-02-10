using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private GameManager gameManager;
    private static float timeSlow = 0.02f;
    private static float slowLength = 50f;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        TimeRestore();
    }

    public void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = timeSlow;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
        gameManager.isCollision = true;
    }

    void TimeRestore()
    {
        Time.timeScale += (1f / slowLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }
}
