using System.Linq;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private bool isSecondPlayer;
    [SerializeField] private TextMeshProUGUI speedometerText;
    [SerializeField] private TextMeshProUGUI rpmText;
    [SerializeField] private WheelCollider[] allWheels;

    private const float HorsePower = 30;
    private const float TurnSpeed = 20;

    private float _horizontalInput;
    private float _forwardInput;
    private string _horizontalAxis;
    private string _verticalAxis;
    private Rigidbody _playerRigidbody;

    private void Awake()
    {
        _horizontalAxis = isSecondPlayer ? "HorizontalArrowKeys" : "Horizontal";
        _verticalAxis = isSecondPlayer ? "VerticalArrowKeys" : "Vertical";
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float speed = Mathf.Round(_playerRigidbody.velocity.magnitude * 3.6f);
        speedometerText.text = "Speed: " + speed + "kph";

        float rpm = Mathf.Round(speed % 30 * 40);
        rpmText.SetText("RPM: " + rpm);
    }

    private void FixedUpdate()
    {
        if (!IsOnGround()) return;
        _horizontalInput = Input.GetAxis(_horizontalAxis);
        _forwardInput = Input.GetAxis(_verticalAxis);

        _playerRigidbody.AddRelativeForce(_forwardInput * HorsePower * Vector3.forward, ForceMode.Acceleration);
        transform.Rotate(Vector3.up, TurnSpeed * _horizontalInput * Time.deltaTime);
    }

    private bool IsOnGround()
    {
        int wheelsOnGround = allWheels.Count(wheel => wheel.isGrounded);
        return wheelsOnGround == 4;
    }
}