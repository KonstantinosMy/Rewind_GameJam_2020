﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuto2 : MonoBehaviour
{
    public GameObject tut2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            tut2.SetActive(false);
        }
    }


 
}
