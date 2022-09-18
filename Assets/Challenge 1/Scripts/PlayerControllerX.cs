using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private const float Speed = 0.02f;
    private const float RotationSpeed = 100;
    private float _verticalInput;

    void Update()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(RotationSpeed * Time.deltaTime * _verticalInput * Vector3.right);
    }
}