using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OrangeButton : MonoBehaviour
{

    public GameObject Button;
    public GameObject OrangeDoor;
    public bool inRange;
    public AudioSource buttonSound;
    private void Start()
    {
        inRange = false;
    }

    private void Update()
    {
        if(inRange && Input.GetKeyDown(KeyCode.F))
        {
            buttonSound.Play();
            Debug.Log("F Pressed");
            OrangeDoor.SetActive(false);

        }
    }
    private void OnTriggerEnter2D (Collider2D collision)
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