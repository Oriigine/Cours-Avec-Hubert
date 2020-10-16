using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_Ship : MonoBehaviour
{
    public float speed = 0.3f;
    public GameObject ship;
    public GameObject laser;
    public Transform firePoint;

    public int shieldPoints = 1;
    public int pv = 3;
    public bool danger = false;
    void Start()
    {
        
    }

    void Update()
    {
        move();
        shoot();
    }


    public void move()
    {
        if(Input.GetKey(KeyCode.D))
        {
            ship.transform.Translate(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            ship.transform.Translate(-speed, 0, 0);
        }
    }

    public void shoot()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newLaser = Instantiate(laser, firePoint.position, transform.rotation);
            Destroy(newLaser, 1);
        }
    }

    public void regenShield()
    {
        if(shieldPoints <=0 && danger == false)
        {
            shieldPoints++;
        }
    }

    public void hit()
    {
        //si je me fais hit ; si j'ai un shield c'est lui qui prend, si j'en ai pas c'est les pv. 
        //quand je suis hit le bool danger passe a true pendant 3/4 secondes (a régler).
    }
}
