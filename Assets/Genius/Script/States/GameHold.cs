using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Genius {
    public class GameHold : MonoBehaviour
    {

        private int maxcount = 15;
        private int currentcount = 0;
        private int blocklight = 0;
        private bool holdgame =false;
        private void Start() {
            Debug.Log("start gamehold"+ GameManager.Instance.GetHoldState());
            GameManager.Instance.GetHoldState().Attach(HoldGame);
        }

        
        void FixedUpdate()
        {
            if(holdgame){
                if (currentcount >= maxcount)
                {
                    currentcount =0;
                    NextLigth();
                }
                if(currentcount == 0)
                {
                    GeniusManager.Instance.BlockturnON(blocklight,true);
                }
                currentcount++;
                
            }
        }

        private void NextLigth()
        {
            blocklight++;
            if (blocklight >= GeniusManager.Instance.GetTotalBlocks())
            {
                blocklight = 0;
            }
        }
        public void HoldGame(){
            holdgame = true;
        }

    }
}


