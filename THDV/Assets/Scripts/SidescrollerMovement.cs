using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidescrollerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 3f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey("a"))
        {
            transform.position += Vector3.left * movementSpeed * Time.deltaTime;

        }
        if (Input.GetKey("d"))
        {
            transform.position += Vector3.right * movementSpeed * Time.deltaTime;
        }
    }
}
