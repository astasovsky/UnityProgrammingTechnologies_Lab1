using UnityEngine;

public class OncomingVehicle : MonoBehaviour
{
    private const float Speed = 15;

    void Update()
    {
        transform.Translate(Time.deltaTime * Speed * Vector3.forward);
    }
}