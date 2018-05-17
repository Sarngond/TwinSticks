using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool recording = true;
	public GameObject pauseImage;

	private float fixedDeltaTime;
	private bool isPaused = false;

	// Use this for initialization
	void Start () {
		PlayerPrefsManager.UnlockLevel (2);
//		print (PlayerPrefsManager.IsLevelUnlocked (1));
//		print (PlayerPrefsManager.IsLevelUnlocked (2));
		fixedDeltaTime = Time.fixedDeltaTime;
		print (fixedDeltaTime);
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton ("Fire1")) {
			recording = false;
		} else {
			recording = true;
		}

		if (Input.GetKeyDown (KeyCode.Escape) && !isPaused) {
			PauseGame ();
			print ("paused");
			isPaused = true;
		} else if (Input.GetKeyDown (KeyCode.Escape) && isPaused) {
			ResumeGame ();
			print ("resumed");
			isPaused = false;
		}
	}

	void PauseGame () {
		pauseImage.SetActive (true);
		Time.timeScale = 0;
		Time.fixedDeltaTime = 0;
	}

	public void ResumeGame() {
		pauseImage.SetActive (false);
		Time.timeScale = 1f;
		Time.fixedDeltaTime = fixedDeltaTime;
	}

//	void OnApplicationPause (bool pauseStatus) {
//		isPaused = pauseStatus;
//	}
}
