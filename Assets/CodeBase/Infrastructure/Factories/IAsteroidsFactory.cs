using CodeBase.GamePlay.Asteroids;
using UnityEngine;

namespace CodeBase.Infrastructure.Factories
{
    public interface IAsteroidsFactory
    {
        public Asteroid CreateAsteroid(Vector3 position);
    }
}