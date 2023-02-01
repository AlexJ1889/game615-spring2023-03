using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    public GameObject _camera;
    public Transform startPos;
    public Transform newPos; 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, 1000, 0);
            _camera.transform.position = newPos.transform.position;
            Invoke("ReturnBack", 5); 
        }
    }

    void ReturnBack()
    {
        _camera.transform.position = startPos.transform.position;
    }
}
