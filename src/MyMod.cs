using Game;
using Game.Mods;
using UnityEngine;

namespace Mod {
    /// <summary>
    /// Mod Entry point, must extend `ScriptableObject` and implement `IGameMod`.
    /// </summary>
    public class MyMod : ScriptableObject, IGameMod {
        public void OnInit(IGameController gameController) {
            Debug.Log("[NewMod] => OnInit");
        }

        public void OnRestart() {
            Debug.Log("[NewMod] => OnRestart");
        }
    }
}