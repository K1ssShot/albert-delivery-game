using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    [SerializeField] private float _fastSpeed = 30f;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Driver driver))
        {
            //applying speed boost to the player
            Debug.Log("boosting player");
            driver._moveSpeed = _fastSpeed;

        }
    }
}
