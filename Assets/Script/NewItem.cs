using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewItem : MonoBehaviour {
	
	public GameObject[] installitem;
	public int number;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//アイテムを設置する
	public void install(int number)
	{
		this.number = number;
		Instantiate (installitem[number]);
	}
}
