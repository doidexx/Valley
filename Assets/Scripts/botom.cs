using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
		
	}

	public void Next() {
		SceneManager.LoadScene(4);
	}
	
	public void StartGame(){
		SceneManager.LoadScene(1);
	}

	public void PlayAgain(){
		SceneManager.LoadScene(4);
	}

	public void QuitGame(){
		Application.Quit();
	}
}
