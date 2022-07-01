using UnityEngine;

namespace CodeBase.GamePlay.Player
{
    [CreateAssetMenu(menuName = "Settings/Create spaceship settings", fileName = "SpaceshipSettings", order = 51)]
    public class SpaceshipSettings : ScriptableObject
    {
        [SerializeField] private float _speed;
        public float Speed => _speed;
    }
}