using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRange : MonoBehaviour
{
    public GameObject prefab;
    public float zoffset = 10;

    private void OnGUI()
    {
        if(GUI.Button(new Rect(10, 10, 100, 50), "Instantiate!"))
        {
            int xcount = Random.Range(1, 6);

            int ycount = Random.Range(2, 5);

            for (int x = 0; x != xcount; ++x)
            {
                for (int y = 0; y != ycount; ++y)
                {
                    var position = new Vector3(x * 2, zoffset, y * 2);
                    Instantiate(prefab, position, Quaternion.identity);
                }
            }
            zoffset += 2;
        }
    }

}
