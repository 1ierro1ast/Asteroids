using System;
using System.Collections;
using CodeBase.Infrastructure.Factories;
using UnityEngine;
using Zenject;
using Random = UnityEngine.Random;

namespace CodeBase.GamePlay.Asteroids
{
    public class AsteroidsSpawn : MonoBehaviour
    {
        private AsteroidsSettings _asteroidsSettings;
        private IAsteroidsFactory _asteroidsFactory;

        [Inject]
        private void Construct(IAsteroidsFactory asteroidsFactory, AsteroidsSettings asteroidsSettings)
        {
            _asteroidsFactory = asteroidsFactory;
            _asteroidsSettings = asteroidsSettings;
        }

        private void OnEnable()
        {
            StartCoroutine(AsteroidSpawnCoroutine());
        }

        private IEnumerator AsteroidSpawnCoroutine()
        {
            while (true)
            {
                _asteroidsFactory.CreateAsteroid(GetPosition());
                yield return new WaitForSeconds(_asteroidsSettings.AsteroidsSpawnDelay);
            }
        }

        private Vector3 GetPosition()
        {
            return new Vector3(transform.position.x,
                Random.Range(-_asteroidsSettings.AsteroidsSpawnRange, _asteroidsSettings.AsteroidsSpawnRange), 0);
        }
    }
}