using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManagerFacade : Singleton<SaveManagerFacade>
{
    private ScoreManager _scoreManager;
    private PlayerData _playerData;
    private UIManager _uiManager;
    

    public void SaveGame()
    {
        _scoreManager = new ScoreManager();
        _playerData = new PlayerData();
        _uiManager = new UIManager();
        _playerData.HP = 12;
        _playerData.Score = _scoreManager.GetScore();
        _uiManager.EnableUISave();
        SaveData(_playerData);
    }

    private void SaveData(PlayerData data)
    {
        Debug.Log("Saving " + data.HP + " HP and " + data.Score + " score");
    }
}
