using System.Collections;
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

        public void BlockInteraction()
        {
            for(int i = 0; i < colorbuttons.Length; i++)
            {
                colorbuttons[i].Interactable(false);
            }
        }

        public void BlockturnON(int _block = -1, bool turnoffothers = false)
        {
            if (_block == -1)
            {
                for (int i = 0; i < colorbuttons.Length; i++)
                {
                    colorbuttons[i].DisplayLight(true);
                }
                return;
            }
            colorbuttons[_block].DisplayLight(true);
            if (turnoffothers)
            {
                for (int i = 0; i < colorbuttons.Length; i++)
                {
                    if(_block != i)
                    {
                        colorbuttons[i].DisplayLight(false);
                    }
                }
            }
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
