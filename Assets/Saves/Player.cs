using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public HighScores highscoresAssets = null;
    public PlayerScore playerScore = new PlayerScore();

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            highscoresAssets.highscore.Add(playerScore);
            highscoresAssets.Save();
        }
    }

}
