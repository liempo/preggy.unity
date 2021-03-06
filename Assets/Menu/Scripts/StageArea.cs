﻿using Michsky.UI.ModernUIPack;
using UnityEngine;

namespace Menu.Scripts {
    public class StageArea : MonoBehaviour {
        // To be set in the Inspector
        public GameObject buttonPrefab;
        public TipArea tipArea;
        public TextAsset stagesJson;

        // JSON data here (title and scene path)
        private Stage[] _stages;
        private Loader _loader;

        private void Start() {
            // Initialize the stage data
            _stages = Stage.Serialize(stagesJson.text);
            _loader = FindObjectOfType<Loader>();

            // Populate StageArea object
            for (var i = 0; i < _stages.Length; i++) {
                var stage = _stages[i];
                var b = Instantiate(
                    buttonPrefab, transform);

                // Setup instantiated button
                var manager = b.GetComponent<ButtonManager>();
                manager.buttonText = stage.title;
                var i1 = i;
                manager.clickEvent.AddListener(
                    delegate { _loader.StartLoader(stage.scene); tipArea.SetTip(i1); }
                );
            }
        }

    }
}
