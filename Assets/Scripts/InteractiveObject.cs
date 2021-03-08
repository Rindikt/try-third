using UnityEngine;
namespace RollABall
{
    abstract class InteractiveObject : MonoBehaviour
    {

        protected abstract void Interection()
        
        private void OnTriggerEnter(Collider other)
        {
            if (! other.TryGetComponent<Player>(out Player player))
            {
                return;
            }
            Interection();
            Destroy(gameObject);
        }
    }
}
