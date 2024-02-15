using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Driver : MonoBehaviour
{
    [SerializeField] private float _steerSpeed = 300f;
    [SerializeField] private float _moveSpeed = 20f;
    [SerializeField] private float _slowSpeed = 10f;
    [SerializeField] private float _fastSpeed = 30f;
    private Camera _mCamera;



    private void Start()
    {
        _mCamera = Camera.main;
    }
    // Update is called once per frame
   private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * _steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }

    private void LateUpdate()
    {
        //for the player main camera possition
        _mCamera.transform.position = transform.position + new Vector3(0, 0, -10);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Boost speed
        _moveSpeed = _fastSpeed;
        Debug.Log(" moving fast");

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //slowing  the player character
        _moveSpeed = _slowSpeed;
        Debug.Log("slowed");
    }




}
