using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerRan : MonoBehaviour
{
   // this is the script to be change for the editor frendly spawn location in level 1 
    public BoxCollider2D BoundsArea;

    private void Start()
    {
        Randomizer();
        Debug.Log("change start Customer");
    }


    // for the random spawn area in the level 1 
    public void Randomizer()
    {
        Bounds bounds = this.BoundsArea.bounds;


        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        this.transform.position = new Vector3(x, y, 0.0f);

    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        // on trigger event for the player using tag but tobe uprade for the new editor frendly spawn location in level 1 
        if (other.tag == "Player")
        {
            Randomizer();
            Debug.Log("nag change pos customer");

        }



    }
}
