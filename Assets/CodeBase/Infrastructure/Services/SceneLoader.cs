﻿using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace CodeBase.Infrastructure.Services
{
    public class SceneLoader : ISceneLoader
    {
        [Inject] private readonly ICoroutineRunner _coroutineRunner;

        public void LoadScene(string name, bool validateSceneName = true, Action onLoaded = null)
        {
            _coroutineRunner.StartCoroutine(LoadSceneCoroutine(name, validateSceneName, onLoaded));
        }

        private IEnumerator LoadSceneCoroutine(string name, bool validateSceneName, Action onLoaded = null)
        {
            if (validateSceneName && SceneManager.GetActiveScene().name == name)
            {
                onLoaded?.Invoke();
                yield break;
            }
            
            AsyncOperation loadOperation = SceneManager.LoadSceneAsync(name);
            loadOperation.allowSceneActivation = false;

            yield return new WaitForSeconds(1f);
            loadOperation.allowSceneActivation = true;
            
            while (!loadOperation.isDone)
                yield return null;

            onLoaded?.Invoke();
        }

        public void Tick()
        {
            Debug.Log("tick");
        }
    }
}