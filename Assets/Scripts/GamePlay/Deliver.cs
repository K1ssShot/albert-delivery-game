using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Deliver : MonoBehaviour
{
  
    [SerializeField] private Color32 _haspackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 _nopackageColor = new Color32(234, 14, 14, 255);
    private bool _hasPackage;
    private SpriteRenderer _spriteRenderer;



   public void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

    }

   public void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("agay");
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Package" && !_hasPackage)
        {
            Debug.Log("package picked");
            _hasPackage = true;
            //Destroy(other.gameObject, destroyDelay);
            _spriteRenderer.color = _haspackageColor;
            Debug.Log("Scored 1");
            UIManager.PlayerScore+=1;



        }

        if (other.tag == "Customer" && _hasPackage)
        {
            Debug.Log("package delivered");
            _hasPackage = false;
            _spriteRenderer.color = _nopackageColor;
            Debug.Log("Scored 2 ");
            UIManager.PlayerScore +=2;
        }
    }
}
