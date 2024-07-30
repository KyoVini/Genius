using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Genius
{
    public class GeniusManager : MonoBehaviour
    {
        [SerializeField] private ColorButtons[] colorbuttons;//inspector
        public static GeniusManager Instance;
        private UnityAction<int> verifygame;
        private int currentround =0;
        public List<int> sequence = new List<int>();
        
        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            else
            {
                Instance = this;
            }
        }
        private void Start() {
            GameManager.Instance.GetInteractiveState().Attach(StartRound);
            GameManager.Instance.GetStartState().Attach(() =>SetInteraction(false));
            for(int i =0;i< colorbuttons.Length;i++){
                colorbuttons[i].SetNewAction(SetVerify);
            }
        }
        public void StartRound(){
            currentround = 0;
            SetInteraction(true);
        }
        public void SetVerify(int id){
            int maxround = sequence.Count;
            if(currentround < maxround){
                if(sequence[currentround] == id){
                    
                }

            }else{
                //novo numero
            }
            

        }
        public void Pressed(int id){

        }
        private void SetInteraction(bool set)
        {
            for(int i = 0; i < colorbuttons.Length; i++)
            {
                colorbuttons[i].Interactable(set);
            }
        }

        public void BlockturnON(int _block = -1)
        {
            if (_block == -1)
            {
                for (int i = 0; i < colorbuttons.Length; i++)
                {
                    colorbuttons[i].DisplayLight(true);
                }
                return;
            }
            colorbuttons[_block].DisplayLight(true);
        }

        public void BlockturnOFF(int _block =-1)
        {
            if(_block == -1)
            {
                for (int i = 0; i < colorbuttons.Length; i++)
                {
                    colorbuttons[i].DisplayLight(false);
                }
                return;
            }
            colorbuttons[_block].DisplayLight(false);
        }
        public int GetTotalBlocks() => colorbuttons.Length;
        public void AddInSequence(int _id ) { sequence.Add(_id); }
        public void CleanSequence(){ sequence.Clear();}

        
    }
}
