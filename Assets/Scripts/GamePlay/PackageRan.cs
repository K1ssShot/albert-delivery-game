using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageRan : MonoBehaviour
{
    
  //old package random controller 
    public BoxCollider2D BoundsArea;

   
    private void Start()
    {
        RandomSpawn();
        Debug.Log("change start package");
    }


    // for the random spawn area in the level 1 
    public void RandomSpawn()
    {
        Bounds bounds = this.BoundsArea.bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        this.transform.position = new Vector3(x, y, 0.0f);

    }

   
    public void OnTriggerEnter2D(Collider2D other)
    {
        // on trigger event for the player using tag but to be uprade for the new editor frendly spawn location in level 1 
        if (other.tag == "Player")
        {
            Debug.Log("nag change pos package");
          
        }



    }

}

