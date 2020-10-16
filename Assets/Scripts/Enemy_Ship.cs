using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Ship : MonoBehaviour
{

    public bool right = false;
    public bool left = false;
    void Update()
    {
        if(right)
        {
            this.transform.Translate(1, 0, 0);
        }

        if (left)
        {
            this.transform.Translate(-1, 0, 0);
        }
    }

    public void shoot()
    {
        //tirer periodiquement genre tt les x secondes.
    }
}
