using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Genius {
    public class GameHold : MonoBehaviour
    {

        private int maxcount = 15;
        private int currentcount = 0;
        private int light = 0;

        
        void FixedUpdate()
        {
            
            if (currentcount >= maxcount)
            {
                currentcount =0;
                NextLigth();
            }
            if(currentcount == 0)
            {
                GeniusManager.Instance.BlockturnON(light,true);
            }
            currentcount++;
        }

        private void NextLigth()
        {
            light++;
            if (light >= GeniusManager.Instance.GetTotalBlocks())
            {
                light = 0;
            }
        }
    }
}


