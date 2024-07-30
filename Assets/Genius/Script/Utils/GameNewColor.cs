using UnityEngine;

namespace Genius {
    public class GameNewColor
    {
        public static int RandomColor()
        {
            int random = Random.Range(0, 4);
            return random;
        }
    }

}

