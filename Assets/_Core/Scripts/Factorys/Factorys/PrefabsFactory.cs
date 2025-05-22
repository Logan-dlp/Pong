using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong.Factorys.Factorys
{
    public class PrefabsFactory : Factory<GameObject>
    {
        [SerializeField] private GameObject _templateGameObject;
        
        List<GameObject> _instanceList = new();

        private void Start()
        {
            Create();
        }

        public override void Create()
        {
            IEnumerator newInstanceCoroutine()
            {
                yield return new WaitForEndOfFrame();
                GameObject newInstance = Instantiate(_templateGameObject);
                _instanceList.Add(newInstance);
            }

            StartCoroutine(newInstanceCoroutine());
        }

        public override void Destroy(GameObject instance)
        {
            if (!_instanceList.Contains(instance))
            {
                Debug.LogWarning("The list does not contain this GameObject !");
                return;
            }
            
            _instanceList.Remove(instance);
            GameObject.Destroy(instance);
        }

        public override void DestroyAll()
        {
            if (_instanceList.Count <= 0)
            {
                Debug.LogWarning("No GameObject has been instantiated !");
                return;
            }
            
            foreach (GameObject gameObject in _instanceList)
            {
                GameObject.Destroy(gameObject);
            }
            
            _instanceList.Clear();
        }
    }
}