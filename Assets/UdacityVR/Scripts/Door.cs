using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    public float doorSpeed;
    public AudioSource doorOpenSound;

    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    public bool locked = true;
    private bool opening = false;


    void Update() {
        // If the door is opening and it is not fully raised
        if(opening == true)
        {
            if (transform.position.y >= 8)
            {
                opening = false;
                return;
            }

            // Animate the door raising up
            transform.Translate(Vector3.up * doorSpeed * Time.deltaTime);
          
        }

    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        if (locked == false)
        {
            // Set the "opening" boolean to true
            opening = true;
            doorOpenSound.Play();

        }
        // (optionally) Else
        else
        {
            // Play a sound to indicate the door is locked
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
