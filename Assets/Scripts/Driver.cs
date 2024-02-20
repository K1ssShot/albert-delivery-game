using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Driver : MonoBehaviour
{
    [SerializeField] private float _steerSpeed = 300f;
    [SerializeField] private float _slowSpeed = 10f;
    [SerializeField] public float _moveSpeed = 20f;
    public SpriteRenderer _spriteRenderer;
    private Camera _mCamera;




    private void Start()
    {
        _mCamera = Camera.main;
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    private void Update()
    {
        float _steerAmount = Input.GetAxis("Horizontal") * _steerSpeed * Time.deltaTime;
        float _moveAmount = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -_steerAmount);
        transform.Translate(0, _moveAmount, 0);

    }

    private void LateUpdate()
    {
        //for the player main camera possition
        _mCamera.transform.position = transform.position + new Vector3(0, 0, -10);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        //slowing  the player character
        _moveSpeed = _slowSpeed;
        Debug.Log("slowed");
    }




}

