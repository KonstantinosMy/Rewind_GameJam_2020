using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    public Animator camAnim;
    public int health;
    public GameObject deathEffect;
    public GameObject explosion;
    public PlayerMovement plrmvmnt;
    public GameObject healthStateHurt;
    public GameObject healthStateInjured;
    public GameObject healthStateDead;
    public GameObject healthStateHealthy;

    public GameObject ded_bg;
    public GameObject ded_txt;
    private bool dead = false;
    private void Update()
    {

        if (health <= 0) {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            healthStateInjured.SetActive(false);
            healthStateDead.SetActive(true);
            dead = true;
            plrmvmnt.enabled = false;
            ded_bg.SetActive(true);
            ded_txt.SetActive(true);
            
        }

        if (health == 2)
        {
            healthStateHurt.SetActive(true);
            healthStateHealthy.SetActive(false);
        }
        if (health == 1)
        {
            healthStateInjured.SetActive(true);
            healthStateHurt.SetActive(false);
        }

        if (dead && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }

    public void TakeDamage(int damage) {
        camAnim.SetTrigger("shake");
        Instantiate(explosion, transform.position, Quaternion.identity);
        health -= damage;
    }
}
