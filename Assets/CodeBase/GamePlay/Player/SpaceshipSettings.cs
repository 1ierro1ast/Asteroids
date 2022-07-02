using UnityEngine;

namespace CodeBase.GamePlay.Player
{
    [CreateAssetMenu(menuName = "Settings/Create spaceship settings", fileName = "SpaceshipSettings", order = 51)]
    public class SpaceshipSettings : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
        [field: SerializeField] public float Health { get; private set; }
    }
}