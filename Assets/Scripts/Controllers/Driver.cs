using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Driver : MonoBehaviour
{
    [SerializeField] private float _steerSpeed = 1f;
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
        _mCamera.transform.position = transform.position + new Vector3(0, 0, -10);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            Debug.Log("Boosting");
            _moveSpeed = _fastSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        _moveSpeed = _slowSpeed;
        Debug.Log("slowed");
    }




}
