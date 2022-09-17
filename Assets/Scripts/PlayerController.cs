using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;

    private void Update()
    {
        //Move the vehicle forward
        transform.Translate(Time.deltaTime * speed * Vector3.forward);
    }
}