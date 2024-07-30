using UnityEngine;
namespace Genius
{
    public class CommandsManager : MonoBehaviour
    {
        public static CommandsManager Instance; 
        public ColorTurnCommand turncommand = new ColorTurnCommand();
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

    }
}