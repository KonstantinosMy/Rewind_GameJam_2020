using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Dash : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    public int dashCount;
    public CameraShake shake;
    public GameObject ico1;
    public GameObject ico2;
    public GameObject ico3;

    public GameObject dashCharges;
    public GameObject NodashCharges;

    public AudioSource dashSound;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;

        dashCount = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (dashCount == 2)
        {
            ico1.SetActive(true);
        }
        if (dashCount == 1)
        {
            ico2.SetActive(true);
        }
        if (dashCount == 0)
        {
            ico3.SetActive(true);
            dashCharges.SetActive(false);
            NodashCharges.SetActive(true);
        }

        if (direction == 0 && dashCount > 0)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                dashSound.Play();
                direction = 1;
                shake.shakeDuration = 0.2f;
                dashCount = dashCount - 1;
               
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                dashSound.Play();
                direction = 2;
                shake.shakeDuration = 0.2f;
                dashCount = dashCount - 1;
               
            }
        }
        else
        {
            if(dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
            }
            else
            {
                dashTime -= Time.deltaTime;

                if (direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                if (direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
            }
        }
    }
}
