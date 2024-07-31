using UnityEngine;

namespace Genius
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance; 
        private IGameState holdstate= new GameState();
        private IGameState startstate= new GameState();
        private IGameState interactivestate= new GameState();
        private IGameState losestate= new GameState();
        public int currentround =0;
        
        private void Awake() {
             if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
        }
        
        void Start()
        {
            Invoke(nameof(CallHoldState),0.01f);
        }
        public IGameState GetHoldState()=> holdstate;
        public IGameState GetStartState()=> startstate;
        public IGameState GetInteractiveState()=> interactivestate;
        public IGameState GetLoseState()=> losestate;
        public void CallHoldState(){
            holdstate.Notify();
        }
        public void CallStartGameState(){
            startstate.Notify();
        }
        public void CallInteractiveState(){
            interactivestate.Notify();
        }
        public void CallLoseState(){
            losestate.Notify();
        }

        
        


    }
}

   
