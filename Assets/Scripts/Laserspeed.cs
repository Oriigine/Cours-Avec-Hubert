using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laserspeed : MonoBehaviour
{
    public bool touchingBorder = false;

    void Start()
    {
        
    }

    void Update()
    {
        this.transform.Translate(0, 0, 1);
    }
}
