using System;
using System.IO;
using UnityEngine;

namespace Labirint
{
    [Serializable]
    public sealed class SavedData
    {
        public string Name;
        public Vector3 Position;
    }
    public class SaveInteractive : MonoBehaviour
    {
        private GameObject[] _gameObjects;
        private SerializableXMLData<SavedData> _serXMLData = new SerializableXMLData<SavedData>();
        private string _path;
            
        private void Start()
        { 
            _gameObjects = GameObject.FindGameObjectsWithTag("Bonus");
            for (int i = 0;i < _gameObjects.Length; i++)
            {
                _path = Path.Combine(Application.persistentDataPath,"Point" + i + ".xml");
                SavedData data = new SavedData();
                data.Position = _gameObjects[i].transform.position;
                data.Name = _gameObjects[i].name;
                _serXMLData.Save(data,_path);
            }
            
        }
    }
    
}
