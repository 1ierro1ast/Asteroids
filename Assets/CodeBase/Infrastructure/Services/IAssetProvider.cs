using CodeBase.GamePlay.Weapons;
using UnityEngine;

namespace CodeBase.Infrastructure.Services
{
    public interface IAssetProvider
    {
        GameObject Instantiate(string path);
        GameObject Instantiate(string path, Vector3 at);
        GameObject Instantiate(string path, Transform parent);
        
        GameObject Instantiate(GameObject prefab);
        GameObject Instantiate(GameObject prefab, Vector3 at);
        GameObject Instantiate(GameObject prefab, Transform parent);

        T Instantiate<T>(string path) where T : Object;
        T Instantiate<T>(string path, Vector3 at) where T : Object;
        T Instantiate<T>(string path, Transform parent) where T : Object;
        
        T Instantiate<T>(T prefab) where T : Object;
        T Instantiate<T>(T prefab, Vector3 at) where T : Object;
        T Instantiate<T>(T prefab, Transform parent) where T : Object;

        int GetAssetAmount(string path);
    }
}