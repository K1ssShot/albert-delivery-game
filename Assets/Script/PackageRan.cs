using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageRan : MonoBehaviour
{
    public BoxCollider2D boundsArea;

    

    private void Start()
    {
        Randomizer();
        Debug.Log("change start package");
    }



    public void Randomizer()
    {
        Bounds bounds = this.boundsArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        this.transform.position = new Vector3(x, y, 0.0f);

    }

   
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Player")
        {
            Randomizer();
            Debug.Log("nag change pos package");
          
        }



    }

}

