using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flightPlayer : MonoBehaviour
{
    public float moveSpeed = 5;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) == true || Input.GetKey(KeyCode.LeftArrow) == true)
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.RightArrow) == true)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) == true || Input.GetKey(KeyCode.UpArrow) == true)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) == true || Input.GetKey(KeyCode.DownArrow) == true)
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
    }
}
