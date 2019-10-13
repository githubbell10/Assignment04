using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// added

//attached to data manager object in all scenes

public class KeepData : MonoBehaviour
{
    public static string PlayerName = "Anonymous";
    public static int PlayerLives;
    public static int PlayerScore;// link to the old game somehow?
    public static int HighScore = 0;
    public static float PlayerSpeed;
    public static int RoundsPlayed = 0;

    public InputField PlayerNameInput;
    public Slider PlayerSpeedSlider;
    public Dropdown PlayerLivesDropdown;
    // don't forget to fill these fields in the inspector for data manager

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); //don't destroy when new scene is loaded
    }
    private void Update()
    {
        //Debug.Log(PlayerName + " has " + PlayerLives + " lives and " + PlayerSpeed + " speed and score of " + PlayerScore);
    }
    public void UpdateName()
    {
        PlayerName = PlayerNameInput.text;
    }
    public void SetLives()
    {
        PlayerLives = PlayerLivesDropdown.value;
    }
    public void ChangeSpeed()
    {
        PlayerSpeed = PlayerSpeedSlider.value;
    }

}
