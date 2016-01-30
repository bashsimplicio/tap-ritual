﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameState : MonoBehaviour {

	public GameSystem gameSystem;
	public GameObject GameUI;
	public GameObject MenuUI;
	public GameObject AboutUI;
	public GameObject HighScoreUI;
	public AudioController audioController;

	/// <summary>
	/// On start game.
	/// </summary>
	void Start()
	{
		MenuUI.SetActive(true);
		GameUI.SetActive(false);
		AboutUI.SetActive(false);
		HighScoreUI.SetActive(false);
	}

	/// <summary>
	/// Start game state.
	/// </summary>
	public void StartGame()
	{
		MenuUI.SetActive(false);
		GameUI.SetActive(true);
		gameSystem.StartGame();
		audioController.StartDanceMusic();
	}

	/// <summary>
	/// Display game menu.
	/// </summary>
	public void GoToMenu()
	{
		AboutUI.SetActive(false);
		GameUI.SetActive(false);
		MenuUI.SetActive(true);

		audioController.StartMenuMusic();
	}

	/// <summary>
	/// Display about UI.
	/// </summary>
	public void GoToAbout()
	{
		MenuUI.SetActive(false);
		AboutUI.SetActive(true);

		audioController.StartAboutMusic();
	}

	/// <summary>
	/// Display the high score UI.
	/// </summary>
	public void GotoHighScore()
	{
		MenuUI.SetActive(false);
		HighScoreUI.SetActive(true);

		audioController.StartHighScoreMusic();
	}

}
