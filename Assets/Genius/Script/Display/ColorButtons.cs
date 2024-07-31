using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
namespace Genius {
    public class ColorButtons : MonoBehaviour, IColorButtons
    {

        [SerializeField] private int id; // inspector
        private Image img;
        private Button btn;
        private Color mycolor;
        private UnityAction<int> myaction;
        private string colorname;

        private bool interactable = false;

        private void Awake()
        {
            img = GetComponent<Image>();
            btn = GetComponent<Button>();
            mycolor = img.color;
            colorname = gameObject.name;
        }
        public void SetId(int _id){
            id=_id;
        }
        public void SetNewAction(UnityAction<int> newaction){
            myaction = newaction;
        }
        //inspector
        public void Press()
        {
            if (interactable)
            {
                if(myaction!=null){
                    myaction(id);
                }
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
        public string GetName(){
            return colorname;
        }
    }

}
