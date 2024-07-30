using System.Collections.Generic;
using UnityEngine;
namespace Genius{
    public class ColorTurnCommand
    {
        private List<ColorTurnOnOff> commandlist = new List<ColorTurnOnOff>();
        public ColorTurnCommand() {
            commandlist.Add(new ColorTurnOnOff(0));
            commandlist.Add(new ColorTurnOnOff(1));
            commandlist.Add(new ColorTurnOnOff(2));
            commandlist.Add(new ColorTurnOnOff(3));
        }
        public void TurnOn(int id) { 
            commandlist[id].TurnOn(); 
            }
        public void TurnOff(int id) { commandlist[id].TurnOff(); }
        

    }
}