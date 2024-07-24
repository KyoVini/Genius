using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Genius {
    public class ColorButtons : MonoBehaviour, IColorButtons
    {

        [SerializeField] private int id; // inspector
        private Image img;
        private Button btn;
        private Color mycolor;


        private bool interactable = true;

        private void Awake()
        {
            img = GetComponent<Image>();
            btn = GetComponent<Button>();
            mycolor = img.color;
        }
        
        //inspector
        public void Press()
        {
            if (interactable)
            {
                //Inject
                Debug.Log(id);
            }
        }
        public void Interactable(bool _interact)
        {
            interactable = _interact;
            btn.interactable = _interact;
        }
        public void DisplayLight(bool turn)
        {
            Color changealpha = mycolor;
            if (turn)
            {
                changealpha.a = 1.0f;
                img.color = mycolor;
            }
            else
            {

                changealpha.a = 0.5f;
                img.color = changealpha;

            }
        }
    }

}
