using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEventManager : MonoBehaviour
{
    public static bool GamePlaying;

    [SerializeField]
    Text _scoreText;

    [SerializeField]
    Text _timerText;

    [SerializeField]
    Text _welcomeText;

    [SerializeField]
    Button _startButton;

    public void Start()
    {
        GamePlaying = false;
        _scoreText.enabled = false;
        _timerText.enabled = false;
    }

	public void GameStarted()
    {
        GamePlaying = true;

        _welcomeText.enabled = false;
        _startButton.interactable = false;
        _scoreText.enabled = true;
        _timerText.enabled = true;
    }
}
