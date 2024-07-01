using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    [SerializeField] private Canvas levelChooseCanvas;

    private void Start() {
        OpenLevelChooseCanvas(false);
    }

    public void OpenLevelChooseCanvas( bool isOpenedNow ) {
        levelChooseCanvas.enabled = isOpenedNow;
    }
}
