using UnityEngine.Events;

namespace Genius{
    
    public class GameState: IGameState   
    {
        private UnityEvent state= new UnityEvent();
        
        public void Attach(UnityAction _listener)
        {
            state.AddListener(_listener);
        }

        public void Detach(UnityAction _listener)
        {
            state.RemoveListener(_listener);
        }

        public void Notify()
        {
            
            if(state != null)
                state.Invoke();
            
           
        }
    }
}

