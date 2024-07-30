using UnityEngine;
using UnityEngine.Events;

namespace Genius{
    public class SimpleButton : MonoBehaviour
    {
        private UnityAction myaction;

        public void DefineButtonAction(UnityAction newaction){
            myaction = newaction;

        }
        public void OnClick(){
            if(myaction != null){
                myaction();
            }
            

        }
    
    }
}

