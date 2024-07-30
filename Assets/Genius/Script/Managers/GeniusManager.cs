using System.Collections.Generic;
using UnityEngine;

namespace Genius
{
    public class GeniusManager : MonoBehaviour
    {
        [SerializeField] private ColorButtons[] colorbuttons;//inspector
        public static GeniusManager Instance;
        
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
        }
        private void Start() {
            
        }

        public void BlockInteraction()
        {
            SetInteraction(false);
        }

        public void ReleaseInteraction()
        {
            SetInteraction(true);
        }

        private void SetInteraction(bool set)
        {
            for(int i = 0; i < colorbuttons.Length; i++)
            {
                colorbuttons[i].Interactable(set);
            }
        }

        public void BlockturnON(int _block = -1)
        {
            Debug.Log("block turn on: " + _block);
            if (_block == -1)
            {
                for (int i = 0; i < colorbuttons.Length; i++)
                {
                    colorbuttons[i].DisplayLight(true);
                }
                return;
            }
            colorbuttons[_block].DisplayLight(true);
        }

        public void BlockturnOFF(int _block =-1)
        {
            if(_block == -1)
            {
                for (int i = 0; i < colorbuttons.Length; i++)
                {
                    colorbuttons[i].DisplayLight(false);
                }
                return;
            }
            colorbuttons[_block].DisplayLight(false);
        }
        public int GetTotalBlocks() => colorbuttons.Length;

        
    }
}
