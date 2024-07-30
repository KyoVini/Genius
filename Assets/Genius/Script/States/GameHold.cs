
using UnityEngine;
namespace Genius {
    public class GameHold : MonoBehaviour
    {
        private int maxcount = 15;
        private int currentcount = 0;
        private int blocklight = 0;
        private bool holdgame =false;
        private void Start() {
            GameManager.Instance.GetHoldState().Attach(Play);
            GameManager.Instance.GetStartState().Attach(Stop);
            GeniusManager.Instance.BlockturnOFF();
        }
        
        void FixedUpdate()
        {
            if(holdgame){
                if (currentcount >= maxcount)
                {
                    currentcount = 0;
                    CommandsManager.Instance.turncommand.TurnOff(blocklight);
                    NextLigth();
                }
                if(currentcount == 0)
                {
                    CommandsManager.Instance.turncommand.TurnOn(blocklight);
                }
                currentcount++;
            }
        }

        private void NextLigth()
        {
            blocklight++;
            if (blocklight >= 4)
            {
                blocklight = 0;
            }
        }
        
        public void Play(){
            holdgame = true;
        }
        public void Stop(){
            holdgame = false;
        }

    }
}


