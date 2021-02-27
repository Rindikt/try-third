using UnityEngine;
namespace RollABall
{
     public class MoveRoll : MonoBehaviour
    {
        [SerializeField] private float _speed = 3.0f;
        private Vector3 _derection;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void Move()
        {
            _derection.x = Input.GetAxis(AxisManager.Horizontal);
            _derection.z = Input.GetAxis(AxisManager.Vertical);

            _derection.Normalize();

            Vector3 movement = new Vector3(_derection.x, 0.0f, _derection.z);

            _rigidbody.AddForce(movement * (_speed * _rigidbody.mass));
        }
    }
}
