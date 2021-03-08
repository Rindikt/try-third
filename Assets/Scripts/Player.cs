using UnityEngine;
using static UnityEngine.Debug;
namespace RollABall
{
    class Player : MoveRoll, IApplayDamage
    {
        [SerializeField] private float _healBar = 5.0f;
        public void ApplayDamage(float demage)
        {
            
            _healBar -= demage;
            Log("Вам нанесено " + demage + ". Здоровья осталось :" + _healBar);
            if (_healBar <= 0)
            {
                Die();
            }
        }

        public void Gethealth(float health)
        {
            _healBar += health;
            Log("вы востоновили " + health + " жизни, теперь у вас " + _healBar + " Здоровья");
        }
        private void Update()
        {
            Move();
        }
    }
}
