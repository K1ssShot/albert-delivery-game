using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject follow;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = follow.transform.position + new Vector3(0,0,-10);
    }
}
