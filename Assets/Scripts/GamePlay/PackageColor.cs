using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class PackageColor : MonoBehaviour
    {
        // for the sprite color controller
        [SerializeField] private Color32 _hasPackageColor = new Color32(234, 14, 14, 255);


        public void OnTriggerEnter2D(Collider2D other)
        {
            //picking package will change player colors

            if(other.TryGetComponent(out Driver driver))
            {
                Debug.Log("color change");
                driver._spriteRenderer.color = _hasPackageColor;
            }  

        }
    }

