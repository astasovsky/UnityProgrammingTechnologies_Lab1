using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private readonly Vector3 _aboveAndBehindOffset = new(0, 5, -7);
    private readonly Vector3 _perspectiveOfDriversSeatOffset = new(0, 2, 1);
    private Vector3 _offset;
    private bool _isAboveAndBehind = true;

    private void Awake()
    {
        _offset = _aboveAndBehindOffset;
    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            _offset = _isAboveAndBehind ? _perspectiveOfDriversSeatOffset : _aboveAndBehindOffset;
            _isAboveAndBehind = !_isAboveAndBehind;
        }

        transform.position = player.transform.position + _offset;
    }
}