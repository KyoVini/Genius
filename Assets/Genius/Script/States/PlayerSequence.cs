using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;
namespace Genius{
    public class PlayerSequence:MonoBehaviour
    {
        private float timer = 1.0f;
        private int lastbutton;
        private int index =0;
        private List<UnityAction> commandlist = new List<UnityAction>();
        
        private void Start() {
            GameManager.Instance.GetStartState().Attach(ShowSequence);
        }
        
        public void SetNewColor(){
            lastbutton = GameNewColor.RandomColor();
            UnityAction command1 = () => CommandsManager.Instance.turncommand.TurnOn(lastbutton);
            UnityAction command2 = () => CommandsManager.Instance.turncommand.TurnOff(lastbutton);
            commandlist.Add(command1);
            commandlist.Add(command2);
        }
        
        public void ShowSequence(){
            GeniusManager.Instance.BlockturnOFF();
            SetNewColor();
            index =0;
            Invoke(nameof(RepeatSequence),timer);
        }
        private void RepeatSequence(){
            if(index < commandlist.Count){
                
                commandlist[index]();
                Invoke(nameof(RepeatSequence),timer);
                index++;
            }else{
                //fase de clique
                Debug.Log("fim da fase");
            }
            

        }

        
        
    }
}
