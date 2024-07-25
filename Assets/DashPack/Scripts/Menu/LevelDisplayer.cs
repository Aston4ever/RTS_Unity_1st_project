using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelDisplayer : MonoBehaviour {
  [SerializeField] private Image levelDifficulty;
  [SerializeField] private TMP_Text levelName;
  [SerializeField] private Image progressValue;
  [SerializeField] private TMP_Text progressText;
  [SerializeField] private TMP_Text coinsText;

  [SerializeField] private SceneChanger sceneChanger;

  [SerializeField] private LevelDataSO[] levels;

  private int curLevelInd = 0;

  private void FillDescription() {
    levelDifficulty.sprite = levels[curLevelInd].Difficulty;
    levelName.text = levels[curLevelInd].Name;

    coinsText.text = PlayerPrefs.GetInt( "Level" + levels[curLevelInd].SceneInd + "Coins", 0 ) + "/3";
    float progress = PlayerPrefs.GetFloat( "Level" + levels[curLevelInd].SceneInd + "Progress", 0 );
    progressText.text = (progress * 100).ToString( "0" ) + "%";
    progressValue.fillAmount = progress;
  }

  private void Start() {
    curLevelInd = 0;
    FillDescription();
  }

  public void NextLevel() {
    if ( curLevelInd + 1 >= levels.Length ) {
      return;
    }

    ChangeLevel( curLevelInd + 1 );
  }
  public void PrevLevel() {
    if ( curLevelInd - 1 < 0 ) {
      return;
    }

    ChangeLevel( curLevelInd - 1 );
  }
  private void ChangeLevel( int levelInd ) {
    curLevelInd = levelInd;
    FillDescription();
  }

  public void StartLevel() {
    sceneChanger.LoadScene(levels[curLevelInd].SceneInd);
  }

}
