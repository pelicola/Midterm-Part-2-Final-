using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
[RequireComponent(typeof(Rigidbody))]

public class BallController : MonoBehaviour
{

    public Vector3 _moveDirection;
    public Rigidbody rb;
    public float speed = 10;


    // Start is called before the first frame update
    void Start()
    {
        InputManager.InIt(myBallController:this);
        InputManager.SetGameControls();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.rotation* (speed * Time.deltaTime * _moveDirection);
    }

    public void SetMovementDirection(Vector3 currentDirection){
        
    _moveDirection = currentDirection;
 

    }
}
