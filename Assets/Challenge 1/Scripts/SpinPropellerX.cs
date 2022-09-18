using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private const float RotateSpeed = 1.5f;
    private readonly Vector3 _rotateStep = new Vector3(0, 0, 360);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * RotateSpeed * _rotateStep);
    }
}