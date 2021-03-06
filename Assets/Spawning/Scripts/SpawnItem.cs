﻿using UnityEngine;

namespace Spawning.Scripts {

    [CreateAssetMenu(
        fileName = "spawn",
        menuName = "Spawn Item",
        order = 0)]

    public class SpawnItem : ScriptableObject {

        public Sprite sprite;
        public SpawnType type;

    }

    public enum SpawnType { Good, Bad }
}
