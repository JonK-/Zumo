using UnityEngine;
using UnityEngine.Networking;

public class PlayerInput : NetworkBehaviour
{
	// TODO : this is temporary
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

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);
	}
}
