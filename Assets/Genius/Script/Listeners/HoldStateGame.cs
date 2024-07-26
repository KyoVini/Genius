using UnityEngine;
using UnityEngine.Events;

namespace Genius{
    
    public class HoldStateGame: IGameState   
    {
        private UnityEvent holdgame= new UnityEvent();
        
        public void Attach(UnityAction _listener)
        {
            holdgame.AddListener(_listener);
            Debug.Log("afsdfa");
        }

        public void Detach(UnityAction _listener)
        {
            holdgame.RemoveListener(_listener);
        }

        public void Notify()
        {
            
            if(holdgame != null)
                holdgame.Invoke();
            
           
        }
    }
}

