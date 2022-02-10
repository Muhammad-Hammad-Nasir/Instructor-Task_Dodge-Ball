using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public int[] numbers;

    void Start()
    {
        Debug.Log(numbers[0]);
        Debug.Log(numbers[numbers.Length - 1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
