using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.EventSystems.StandaloneInputModule;

public class Player : MonoBehaviour
{
    private InputAction _inputMove;

    // Start is called before the first frame update
    void Start()
    {
        //inputMove = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        this.transform.position -= Vector3.left * x * 0.1f;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Vector3 v = collision.rigidbody.velocity;
            Vector3 ballv = Vector3.Normalize(new Vector3(v.x, 1, 1));
            collision.rigidbody.velocity = ballv * 50;
        }
    }
}
