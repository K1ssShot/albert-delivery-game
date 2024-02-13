using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Deliver : MonoBehaviour
{
    //[SerializeField] float destroyDelay = 0.5f;
    [SerializeField] Color32 haspackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 nopackageColor = new Color32(234, 14, 14, 255);
    bool hasPackage;
  
    SpriteRenderer spriteRenderer;



    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("agay");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("package picked");
            hasPackage = true;
            //Destroy(other.gameObject, destroyDelay);
            spriteRenderer.color = haspackageColor;
            Debug.Log("Scored 1");
            GameManager.numScore+=1;



        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("package delivered");
            hasPackage = false;
            spriteRenderer.color = nopackageColor;
            Debug.Log("Scored 2 ");
            GameManager.numScore +=2;
        }
    }
}
