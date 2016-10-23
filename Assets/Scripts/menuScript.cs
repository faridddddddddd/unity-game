using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class menuScript : MonoBehaviour {

	// Use this for initialization

	public GameObject menu;
	private bool panelEnable = false;
	void Start () {
		Debug.Log ("start");

		// anti-pattern, use Transform.findChild is more efficient
		menu = GameObject.Find ("Canvas/Panel"); 

		Debug.Log (menu);
		menu.SetActive (panelEnable);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void openMenu() {
		Debug.Log ("fire the open Menu Button");

		panelEnable =! panelEnable;
		menu.SetActive (panelEnable);
	
	}


}
