using UnityEngine;

namespace Genius
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private GameObject hitscreen;
        [SerializeField] private GeniusManager genius;
        [SerializeField] private DescriptionObject description;
        private void Start() 
        {
            GameManager.Instance.GetHoldState().Attach(genius.BlockInteraction);
            GameManager.Instance.GetStartState().Attach(genius.ReleaseInteraction);
            
            
            GameManager.Instance.GetHoldState().Attach(ShowHit);
            GameManager.Instance.GetStartState().Attach(HideHit);

            GameManager.Instance.GetHoldState().Attach(description.HoldGame);
            GameManager.Instance.GetStartState().Attach(description.StartGame);

            hitscreen.GetComponent<SimpleButton>().DefineButtonAction(GameManager.Instance.CallStartGameState);
        }
        public void ShowHit(){
            hitscreen.SetActive(true);
        }
        public void HideHit(){
            hitscreen.SetActive(false);
        }
        
    }
}

