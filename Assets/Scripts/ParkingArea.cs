using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingArea : MonoBehaviour
{
    public GameObject car; // Reference to the car GameObject
    public GameObject parkingArea; // GameObject representing the parking area
    private BoxCollider carCollider; // Collider component of the car
    private BoxCollider parkingCollider; // Collider component of the parking area
    private UIManager2 UIManagerScript2;

    // Start is called before the first frame update
    void Start()
    {
        // Get the colliders of the car and parking area
        carCollider = car.GetComponent<BoxCollider>();
        parkingCollider = parkingArea.GetComponent<BoxCollider>();
        UIManagerScript2 = GameObject.Find("UI Manager 2").GetComponent<UIManager2>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the boundaries of the car collider are completely inside the boundaries of the parking area collider
        if (parkingCollider.bounds.Contains(carCollider.bounds.min) && parkingCollider.bounds.Contains(carCollider.bounds.max))
        {
            // Print "Mission accomplished!" message and pause the game
            Debug.Log("Mission completed! You successfully parked the car!");
            
            UIManagerScript2.GetComponent<Canvas>().enabled = true;
            
        }
    }
}
