using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labirint
{
    public class Key : MonoBehaviour
    {
        [SerializeField] GameObject Door;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Door.gameObject.SetActive(false);
            }
        }
    }

}
