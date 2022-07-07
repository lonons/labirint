using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labirint
{
    public class Finish : MonoBehaviour
    {
        private GameController _gameController;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                GameObject go = GameObject.Find("GameControllerObject");
                _gameController = go.GetComponent<GameController>();
                _gameController.Win();
            }
        }
    }

}
