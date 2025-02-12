using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomCursor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        transform.position = Input.mousePosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Input.mousePosition;
    }
}
