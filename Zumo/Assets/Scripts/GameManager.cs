using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance = null; 

	// Fields
	private int _playerScore;

	// Attached Objects
	public Text ScoreUI;

	// Properties
	public int PlayerScore 
	{ 
		get { return _playerScore; }
		private set 
		{
			_playerScore = value;
			UpdateScoreUI ();
		}
	}

	// Constructor
	public GameManager ()
	{
	}

	// Methods
	void Awake()
	{
		//Check if instance already exists
		if (Instance == null)

			//if not, set instance to this
			Instance = this;

		//If instance already exists and it's not this:
		else if (Instance != this)

			//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
			Destroy(gameObject);    

		//Sets this to not be destroyed when reloading scene
		DontDestroyOnLoad(gameObject);
	}

	public void UpdateScoreUI () 
	{
		ScoreUI.text = "Score : " + PlayerScore.ToString ();
	}

	public void AddPlayerScore (int amount = 10)
	{
		PlayerScore += amount;
	}

	public void SubtractPlayerScore (int amount = 10)
	{
		PlayerScore -= amount;
	}
}
