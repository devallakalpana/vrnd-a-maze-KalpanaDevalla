using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	//public bool doorIsClosed = true;
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 

    public bool locked = true;

    // Create a boolean value called "opening" that can be checked in Update()
    public bool openDoor = false;

    //Audio Source and soundclips for door openining and door closed
    public AudioSource soundSource;
    public AudioClip doorLocked;
    public AudioClip doorOpen;



    void Update()
    {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (openDoor && transform.position.y < 7.5f)
        {
            transform.Translate(0, 1.5f * Time.deltaTime, 0, Space.World);
        }
    }



  public void OnDoorClicked()
    {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked

        if (locked == false)
        {
            //Trigger the door to open via animation script and play opening door sound
            openDoor = true;
            soundSource.clip = doorOpen;
            soundSource.Play();
        }
        else
        {
            //Play locked door audio clip
            soundSource.clip = doorLocked;
            soundSource.Play();
        }
}

public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;

    }
}
