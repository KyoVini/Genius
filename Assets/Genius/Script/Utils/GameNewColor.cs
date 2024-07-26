using UnityEngine;

namespace Genius {
    public class GameNewBlock
    {
        public static int NewBlock()
        {
            int random = Random.Range(0, 4);
            return random;
        }
    }

}

