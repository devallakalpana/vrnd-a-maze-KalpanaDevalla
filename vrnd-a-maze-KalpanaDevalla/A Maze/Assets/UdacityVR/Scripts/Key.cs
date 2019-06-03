using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
	//Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door door;
    public float verticalSpeed = 0.7f;
    public float rotationalSpeed = 5f;
    private Vector3 startingPosition;
    public bool keyCollected = false;

    void Start()
    {
        startingPosition = transform.position;
    }
    void Update ()
	{
        transform.position = startingPosition + new Vector3(0f, Mathf.Sin(Time.time) * verticalSpeed, 0f);
        transform.Rotate(0f, Mathf.Sin(Time.time) * rotationalSpeed, 0f);
    }

	public void OnKeyClicked ()
	{
        
        // Instatiate the KeyPoof Prefab where this key is located
        Instantiate(keyPoof, transform.position, Quaternion.Euler(-90, 0, 0));
        keyCollected = true;
        // door.GetComponent<Door>().Unlock();
        Destroy(gameObject);
        door.Unlock();

        //	Debug.Log ("Door Unlock function called");

        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
    }

}