using UnityEngine;

namespace CodeBase.GamePlay.Asteroids
{
    [CreateAssetMenu(menuName = "Settings/Create asteroids settings", fileName = "AsteroidsSettings", order = 51)]
    public class AsteroidsSettings : ScriptableObject
    {
        [field: SerializeField] public Asteroid AsteroidPrefab { get; private set; }
        [field: SerializeField] public float AsteroidsSpawnRange { get; private set; }
        [field: SerializeField] public float AsteroidsSpawnDelay { get; private set; }
        [field: SerializeField] public float MinAsteroidDamage { get; private set; }
        [field: SerializeField] public float MaxAsteroidDamage { get; private set; }
        
        [field: SerializeField] public float MinAsteroidSpeed { get; private set; }
        [field: SerializeField] public float MaxAsteroidSpeed { get; private set; }
        [field: SerializeField] public float MinAsteroidSize { get; private set; }
        [field: SerializeField] public float MaxAsteroidSize { get; private set; }
    }
}