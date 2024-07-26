using UnityEngine.Events;
namespace Genius{
    public interface IGameState 
    {
        public void Attach(UnityAction _listener);

        public void Detach(UnityAction _listener);

        public void Notify();
    }
}

