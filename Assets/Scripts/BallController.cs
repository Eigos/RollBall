using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody rb;
    public int point; 
    public float speed;
    public GameController gameController;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float hValue = Input.GetAxis("Horizontal");
        float vValue = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(hValue * speed, rb.velocity.y, vValue * speed);
    }

    void OnTriggerEnter(Collider other) {
        point++;
        Destroy(other.gameObject);
        gameController.AddNewPoint();
    }
}
