using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float Speed = 20;
    private const float TurnSpeed = 20;
    private float _horizontalInput;
    private float _forwardInput;

    private void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Time.deltaTime * Speed * _forwardInput * Vector3.forward);
        transform.Rotate(Vector3.up, TurnSpeed * _horizontalInput * Time.deltaTime);
    }
}