using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour
{

	// respond on collisions
	void OnCollisionEnter(Collision newCollision)
	{
		Debug.LogError("This is Restart script. I am being called!");
		Debug.LogError("Game manager has restartLevel = "+GameManager.gm.restartLevel);
		// only do stuff if hit by a projectile
		if (newCollision.gameObject.tag == "Projectile") {
			// call the NextLevel function in the game manager
			Debug.LogError("This is inside!!");
			GameManager.gm.Startover();
		}
	}
}

