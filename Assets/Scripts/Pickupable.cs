using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{

    public GameObject Keycard;
    public bool hasKeycard;
    public bool inRange;
    public GameObject uiKeycard;
 
    private void Start()
    {
        inRange = false;
        hasKeycard = false;
    }

    private void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.F))
        {
            uiKeycard.SetActive(true);
            Debug.Log("F Pressed");
            hasKeycard = true;
            gameObject.SetActive(false);

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("In range");
            inRange = true;

        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Out of range");
        inRange = false;

    }
}
