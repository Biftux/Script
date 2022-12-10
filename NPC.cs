using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Health NPC
    public int health = 5;

    // Level NPC 
    public int level = 1;

    // Speed NPC
    public int speed = 1.2f;
    
 

    void Start()
    { 
        // add level in health
        health += level;
        // console
        print(health)
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition; 
    }
}
