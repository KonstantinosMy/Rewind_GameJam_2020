using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrift : MonoBehaviour
{

    public GameObject UpperCamera;
    public bool isUp;

    void Start()
    {
        isUp = false;
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Upper Floor");
           
                isUp = true;
                UpperCamera.SetActive(true);
            
        }
    }


}
