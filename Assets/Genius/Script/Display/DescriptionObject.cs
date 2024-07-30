using TMPro;
using UnityEngine;
namespace Genius{
    public class DescriptionObject : MonoBehaviour
    {
        [SerializeField]private TextMeshProUGUI description;
        
        public void HoldGame(){
            SetText("- Press to start -");
        }
        public void StartGame(){
            SetText("- Remember the sequence -");
        }
        private void SetText(string newtext){
            if(description !=null){
                description.text = newtext;
            }   
        }
        
    }

}
