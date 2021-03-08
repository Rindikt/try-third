using UnityEngine;
using Random = UnityEngine.Random;
namespace RollABall 
{ 
    class BadBonus : InteractiveObject, IFly, IRotation
    {
        #region Fields
        private float _lengthFly;
        private float _speedRotation;
        private Player _ball;
        private float demage = 2.0f;
        #endregion

        #region UnityMethod
        private void Awake()
        {
            _ball = FindObjectOfType<Player>();
            _lengthFly = Random.Range(1.0f, 2.0f);
            _speedRotation = Random.Range(10.0f, 50.0f);
        }
        #endregion

        #region Methods

        protected override void Interection()
        {

        }

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lengthFly), transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }
        #endregion
    }
}
