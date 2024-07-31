using UnityEngine;
namespace Genius {
    public class LoseState : MonoBehaviour
    {
        
        void Start()
        {
            GameManager.Instance.GetLoseState().Attach(CleanGame);
        }
        public void CleanGame(){
            GeniusManager.Instance.CleanSequence();
            Invoke(nameof(ResetGame),2.0f);
        }
        private void ResetGame(){
            GameManager.Instance.CallHoldState();
        }
        

    }
}