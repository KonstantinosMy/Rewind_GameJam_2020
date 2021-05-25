using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDriftLower : MonoBehaviour
{

    public GameObject LowerCamera;
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
            Debug.Log("Lower Floor");

            isUp = true;
            LowerCamera.SetActive(true);
            UpperCamera.SetActive(false);

        }
    }


}
