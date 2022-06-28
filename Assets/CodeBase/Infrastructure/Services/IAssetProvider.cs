using UnityEngine;

namespace CodeBase.Infrastructure.Services
{
    public interface IAssetProvider
    {
        GameObject Instantiate(string path);
        GameObject Instantiate(string path, Vector3 at);
        GameObject Instantiate(string path, Transform parent);
        
        T Instantiate<T>(string path) where T : Object;
        T Instantiate<T>(string path, Vector3 at) where T : Object;
        T Instantiate<T>(string path, Transform parent) where T : Object; 
        
        int GetAssetAmount(string path);

    }
}