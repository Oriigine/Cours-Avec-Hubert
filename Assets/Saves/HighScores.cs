using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System;

[Serializable]
public class PlayerScore
{
    public string m_playerName;
    public int m_score;

    public PlayerScore() { }

    public PlayerScore(string _playerName, int _score)
    {
        m_playerName = _playerName;
        m_score = _score;
    }
}

[CreateAssetMenu(fileName = "Game/Highscores")]
public class HighScores : ScriptableObject
{

    public List<PlayerScore> highscore = new List<PlayerScore>();

    public void Save()
    {
        string json = JsonUtility.ToJson(this, true);
        File.WriteAllText(Application.persistentDataPath + "/save01.json", json);
        Debug.Log("File saved at : " + Application.persistentDataPath + "/save01.json");
    }

    public void Load()
    {
        string json = File.ReadAllText(Application.persistentDataPath + "/save01.json");
        JsonUtility.FromJsonOverwrite(json, this);
        Debug.Log("File Loaded from : " + Application.persistentDataPath + "/save01.json");
    }
}
