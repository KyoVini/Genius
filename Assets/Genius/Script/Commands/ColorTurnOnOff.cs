namespace Genius{
    public class ColorTurnOnOff:IColorSwitch
    {
        private int id;
        public ColorTurnOnOff(int _id){
            id = _id;
        }
        public void TurnOn(){
             GeniusManager.Instance.BlockturnON(id);

        }
        public void TurnOff(){
            GeniusManager.Instance.BlockturnOFF(id);
        }
        
    }
}