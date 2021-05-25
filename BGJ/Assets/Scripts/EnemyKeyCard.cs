using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKeyCard : MonoBehaviour
{

    public Animator camAnim;
    public int health;
    public GameObject deathEffect;
    public GameObject explosion;
    public GameObject keycard;

    private void Update()
    {
        if (health <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            keycard.SetActive(true);
            keycard.transform.parent = null;
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        camAnim.SetTrigger("shake");
        Instantiate(explosion, transform.position, Quaternion.identity);
        health -= damage;
    }
}
