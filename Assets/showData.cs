using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showData : MonoBehaviour
{
    public Text PanelNameText;
    public Text PanelLivesText;
    public Text PanelSpeedText;
    public Text PanelScoreText;
    public Text PanelHighScoreText;
    public Text PanelRoundsPlayedText;

    private void Awake()
    {
        PanelNameText.text = KeepData.PlayerName;
        PanelLivesText.text = KeepData.PlayerLives.ToString();
        PanelSpeedText.text = KeepData.PlayerSpeed.ToString();
        PanelHighScoreText.text = "High: " + KeepData.HighScore.ToString();
        PanelRoundsPlayedText.text = "Rounds: " + KeepData.RoundsPlayed.ToString();
    }
    private void Update()
    {
        PanelScoreText.text = Score.PinCount.ToString();
    }
}
