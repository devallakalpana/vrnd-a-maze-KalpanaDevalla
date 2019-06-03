using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Create a reference to the CoinPoofPrefab
    public GameObject CoinPoof;
    public static int CollectedCoins = 0;

    public float verticalSpeed = 0.7f;
    public float rotationalSpeed = 5f;
    private Vector3 startingPosition;
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startingPosition + new Vector3(0f, Mathf.Sin(Time.time) * verticalSpeed, 0f);
        transform.Rotate(0f, Mathf.Sin(Time.time) * rotationalSpeed, 0f);

    }
    
    public void OnCoinClicked()
    {
       Instantiate(CoinPoof, transform.position, Quaternion.Euler(-90, 0, 0));

        // Destroying the coin gameobject
        Destroy(gameObject);

        //Adding one more coin to the total number collected so far
        CollectedCoins = CollectedCoins + 1;

        //Debug.Log("Number of collected coins : " + CollectedCoins);
    }


}
