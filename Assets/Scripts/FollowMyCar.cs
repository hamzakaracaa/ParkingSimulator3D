using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMyCar : MonoBehaviour
{
    public Transform carTransform; // Reference to the car's transform component

    public float distance = 5f; // Distance between the camera and the car
    public float height = 2f; // Camera height
    public float rotationDamping = 3f; // Rotation damping factor

    private Vector3 offset; // Initial distance between the camera and the car

    // Start is called before the first frame update
    void Start()
    {
        // Calculate the initial offset
        offset = transform.position - carTransform.position;
    }

    // LateUpdate is called once per frame, after Update
    void LateUpdate()
    {
        // Get the desired rotation angle of the car
        float wantedRotationAngle = carTransform.eulerAngles.y;
        float wantedHeight = carTransform.position.y + height;

        // Get the current rotation angle and height of the camera
        float currentRotationAngle = transform.eulerAngles.y;
        float currentHeight = transform.position.y;

        // Smoothly interpolate the rotation angle and height
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);
        currentHeight = Mathf.Lerp(currentHeight, wantedHeight, rotationDamping * Time.deltaTime);

        // Calculate the new rotation and position
        Quaternion currentRotation = Quaternion.Euler(0, currentRotationAngle, 0);
        Vector3 newPosition = carTransform.position - (currentRotation * Vector3.forward * distance);
        newPosition.y = currentHeight;

        // Move the camera to the new position and make it look at the car
        transform.position = newPosition;
        transform.LookAt(carTransform);
    }
}
