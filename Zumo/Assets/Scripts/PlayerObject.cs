using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour 
{
	public int PlayerScore = 0;

	public SpriteRenderer PlayerImage;


	void Start () 
	{

	}

	public override void OnStartLocalPlayer()
	{
		PlayerImage.color = Color.blue;
	}

	void Update () 
	{
		// TODO : for testing

		if (!isLocalPlayer) // Only the local player should execute the movement code
		{
			return;
		}

		//		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		//		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		//		transform.Rotate(0, x, 0);
		//		transform.Translate(0, 0, z);

		if (Input.GetKeyDown (KeyCode.A)) 
		{
			AddPlayerScore ();
		} 
		else if (Input.GetKeyDown (KeyCode.D)) 
		{
			SubtractPlayerScore ();
		}
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
