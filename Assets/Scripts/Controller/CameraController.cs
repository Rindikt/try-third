using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject _player;
    private Vector3 _ofset;

    private void Start()
    {
        _ofset = transform.position - _player.transform.position;
    }

    private void Update()
    {
        transform.position = _player.transform.position + _ofset;
    }
}
