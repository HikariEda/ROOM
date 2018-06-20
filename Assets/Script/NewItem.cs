using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewItem : MonoBehaviour {
	
	public GameObject[] installitem;
	public int number;
	private List<GameObject> myList;

	// Use this for initialization
	void Start () {
		if (myList == null) {
			myList = new List<GameObject> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//アイテムを設置する
	public void install(int number)
	{
		this.number = number;
		GameObject go = Instantiate (installitem[number]);
		if (myList == null) {
			myList = new List<GameObject> ();
		}
		myList.Add (go);
	}

	public void MoveOnOff(bool value){
		if (myList != null) {
			for (int i = 0; i < myList.Count; i++) {
				myList [i].GetComponent<MouseDrag> ().on = value;
			}
		}
	}

}
