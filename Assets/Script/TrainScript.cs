﻿using UnityEngine;
using System.Collections;
public class TrainScript : MonoBehaviour
{
	public GameObject[] Train;
	public int number;

	void Start ()
	{
		//number = Random.Range (0, Train.Length);
		//Instantiate(Train[number],transform.position,transform.rotation);
	}

	public void Changed ()
	{
		number = Random.Range (0, Train.Length);
	}
}