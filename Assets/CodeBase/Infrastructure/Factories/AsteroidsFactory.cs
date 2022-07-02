using CodeBase.GamePlay.Asteroids;
using CodeBase.Infrastructure.Services;
using UnityEngine;
using Asteroid = CodeBase.GamePlay.Asteroids.Asteroid;

namespace CodeBase.Infrastructure.Factories
{
    public class AsteroidsFactory : IAsteroidsFactory
    {
        private readonly IAssetProvider _assetProvider;
        private readonly AsteroidsSettings _asteroidsSettings;

        public AsteroidsFactory(IAssetProvider assetProvider, AsteroidsSettings asteroidsSettings)
        {
            _assetProvider = assetProvider;
            _asteroidsSettings = asteroidsSettings;
        }
        public Asteroid CreateAsteroid(Vector3 position)
        {
            var asteroid = _assetProvider.Instantiate<Asteroid>(_asteroidsSettings.AsteroidPrefab, position);
            asteroid.SetParameters(GetAsteroidSpeed(), GetAsteroidSize(), GetAsteroidDamage());
            return asteroid;
        }

        private float GetAsteroidDamage()
        {
            return Random.Range(_asteroidsSettings.MinAsteroidDamage, _asteroidsSettings.MaxAsteroidDamage);
        }

        private float GetAsteroidSize()
        {
            return Random.Range(_asteroidsSettings.MinAsteroidSize, _asteroidsSettings.MaxAsteroidSize);
        }

        private float GetAsteroidSpeed()
        {
            return Random.Range(_asteroidsSettings.MinAsteroidSpeed, _asteroidsSettings.MaxAsteroidSpeed);
        }
    }
}