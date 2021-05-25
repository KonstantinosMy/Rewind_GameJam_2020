using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Pickupable pickup;
    public BoxCollider2D col;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pickup.hasKeycard)
        {
            Debug.Log("Door Open");
            col.enabled = false;
        }
    }
}
