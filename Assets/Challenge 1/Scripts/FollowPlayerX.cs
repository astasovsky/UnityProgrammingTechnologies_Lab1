using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    private readonly Vector3 _offset = new Vector3(30, 0, 10);

    // Update is called once per frame
    private void Update()
    {
        transform.position = plane.transform.position + _offset;
    }
}