using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isSecondPlayer;

    private const float Speed = 20;
    private const float TurnSpeed = 20;
    private float _horizontalInput;
    private float _forwardInput;
    private string _horizontalAxis;
    private string _verticalAxis;

    private void Awake()
    {
        _horizontalAxis = isSecondPlayer ? "HorizontalArrowKeys" : "Horizontal";
        _verticalAxis = isSecondPlayer ? "VerticalArrowKeys" : "Vertical";
    }

    private void Update()
    {
        _horizontalInput = Input.GetAxis(_horizontalAxis);
        _forwardInput = Input.GetAxis(_verticalAxis);

        transform.Translate(Time.deltaTime * Speed * _forwardInput * Vector3.forward);
        transform.Rotate(Vector3.up, TurnSpeed * _horizontalInput * Time.deltaTime);
    }
}