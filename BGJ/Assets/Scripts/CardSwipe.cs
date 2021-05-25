using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class CardSwipe : MonoBehaviour
{
    public GameObject redLight;
    public GameObject greenLight;
    public AudioSource swipeSound;
    public GameObject staticDoor;
   // public GameObject animationDoor;
    public Pickupable keycard;
    public bool hasKeycard =false;
    private bool inRange=false;
    private void Update()
    {
        if (inRange && hasKeycard && Input.GetKeyDown(KeyCode.F))
        {
            swipeSound.Play();
            staticDoor.SetActive(false);
            // animationDoor.SetActive(true);
            redLight.SetActive(false);
            greenLight.SetActive(true);
        }

        hasKeycard = keycard.hasKeycard;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("in range of swiper");
            inRange = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
        
    {
        Debug.Log("out of range of swiper");
        inRange = false;
    }
}


