using UnityEngine;
using UnityEngine.Networking;

public class PlayerObject : NetworkBehaviour 
{
	// Fields

	// Attached Objects
	public SpriteRenderer PlayerImage;

	public override void OnStartLocalPlayer()
	{
		PlayerImage.color = Color.blue;
	}

	public void Update()
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
			Debug.Log ("### A PRESSED");
			GameManager.Instance.AddPlayerScore();
		} 
		else if (Input.GetKeyDown (KeyCode.D)) 
		{
			GameManager.Instance.SubtractPlayerScore ();
		}
	}
}
