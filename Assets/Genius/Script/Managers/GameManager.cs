using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Genius
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance; 
        private IGameState holdstate;
        private void Awake() {
             if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
            holdstate = new HoldStateGame();
            Debug.Log("awake game manager");
        }
        
        
        void Start()
        {
            
            GameNewBlock.NewBlock();
            Invoke(nameof(CallHoldState),0.1f);

        }

        public IGameState GetHoldState()=>holdstate;
        public void CallHoldState(){
            holdstate.Notify();
        }

        
        


    }
}

   
