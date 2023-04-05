using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	// in here, we will handle button presses... and then pass them into the animator
	// controller component which will then set paramteers...and then make anim 
	// state changes FTW!
	public Animator anim;
	public AudioSource jumpFx;
	public AudioSource slideFx;
	public AudioSource gameOverSfx;

	public void OnEnable()
	{
		anim = this.gameObject.GetComponent<Animator>();
	}

	public void PlayerControlsUpdate()
	{
		if (anim != null)
		{

			if (Input.GetKeyDown(KeyCode.UpArrow) == true)
			{
				jumpFx.Play();
				anim.SetTrigger("Jump");
			}

			if (Input.GetKeyDown(KeyCode.DownArrow) == true)
            {
				slideFx.Play();
				anim.SetTrigger("Slide");
			}
				

		}
	}

	// Update is called once per frame
	void Update () {
	
		PlayerControlsUpdate();
	}
    private void OnTriggerEnter(Collider collider)
    {
		
		if (collider.transform.tag == "Obstacle")
		{
			CoinCollectorController.coinCount = 0;
			gameOverSfx.Play();
			PlayerManager.gameOver = true;
		}
	}   
}
