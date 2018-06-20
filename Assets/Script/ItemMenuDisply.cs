using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMenuDisply : MonoBehaviour {
	
	public GameObject menuCanvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Canvas表示と非表示切り替え
	public void Changedmenu( bool value ){
		//Debug.Log (value);
		if (value) {
			menuCanvas.SetActive (true);
		} else {
			menuCanvas.SetActive (false);
		}
	}

	//Canvas非表示
	public void Closemenu(){
		menuCanvas.SetActive (false);
	}
	//Canvas表示
	public void Openmenu(){
		menuCanvas.SetActive (true);	
	}
}
