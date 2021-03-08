using UnityEngine;
namespace RollABall
{
    class GoodBonus : InteractiveObject, IFly, IRotation, IFlicker
    {
        #region Fields
        private Material _material;
        private Player _ball;
        private float _speedRotation;
        private float _lenghtFly;
        #endregion

        #region UnityMethod
        private void Awake()
        {
            _ball = FindObjectOfType<Player>();
            _lenghtFly = Random.Range(1.0f, 2.0f);
            _speedRotation = Random.Range(10.0f, 50.0f);
            _material = GetComponent<Renderer>().material;
        }
        #endregion

        #region Methods

        public void Fly()
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, _lenghtFly), transform.localPosition.z);
        }

        public void Rotation()
        {
            transform.Rotate(Vector3.up * (Time.deltaTime * _speedRotation), Space.World);
        }

        public void Flicker()
        {
            _material.color = /*Random.ColorHSV(10.0f,20.0f); */new Color(_material.color.r, _material.color.b, _material.color.b, Mathf.PingPong(Time.time, 10.0f));
        }

        protected override void Interection()
        {
           
        }
        #endregion
    }
}
