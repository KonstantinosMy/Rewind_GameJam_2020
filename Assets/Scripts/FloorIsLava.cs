using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorIsLava : MonoBehaviour
{
    public GameObject death_bg;
    public GameObject death_text;
    private bool dead;

    private void Update()
    {
        if (dead && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("DED NIGA");
            death_bg.SetActive(true);
            death_text.SetActive(true);
            dead = true;
            
        }
    }
}
