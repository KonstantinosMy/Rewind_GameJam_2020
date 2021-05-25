using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BlueButton : MonoBehaviour
{

    public GameObject Button;
    public GameObject BlueDoor;
    public bool inRange;
    public float timeInSeconds;
    public AudioSource tickingSound;
    private void Start()
    {
        inRange = false;
    }

    private void Update()
    {
        if (inRange && Input.GetKeyDown(KeyCode.F))
        {
            tickingSound.Play();
            Debug.Log("F Pressed");
            BlueDoor.SetActive(false);
            StartCoroutine("Time");
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

    public IEnumerator Time()
    {
        yield return new WaitForSeconds(timeInSeconds);
        tickingSound.Stop();
        BlueDoor.SetActive(true);
        
    }


}

