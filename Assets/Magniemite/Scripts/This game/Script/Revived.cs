using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Revived : MonoBehaviour {
	public GameObject ReviveScreen;
	public GameObject AdErrorScreen;
	public GameObject YouSkiped;
	public bool Reserect = false;



	private GameObject InvisPuffer5;


	private void Awake()
	{
		InvisPuffer5 = GameObject.Find("InvisablePufferfish5");
	}


	// Use this for initialization
	void Start () {
		ReviveScreen.gameObject.SetActive(false);
		AdErrorScreen.gameObject.SetActive(false);
		YouSkiped.gameObject.SetActive(false);
	}
	
	void Reserecting()
	{
		Reserect = true;
		Invoke(" Reserected", 1);
	}
	void Reserected()
	{
		Reserect = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (InvisPuffer5.GetComponent<Player_Start>().ReviveScreen == true)
		{
			ReviveScreen.gameObject.SetActive(true);
		}
		else
		{
			ReviveScreen.gameObject.SetActive(false);
		}
		//
		if (InvisPuffer5.GetComponent<Player_Start>().ADError == true)
		{
			AdErrorScreen.gameObject.SetActive(false);
		}
		else
		{
			AdErrorScreen.gameObject.SetActive(false);
		}
		//
		if (InvisPuffer5.GetComponent<Player_Start>().Skiped == true)
		{
			YouSkiped.gameObject.SetActive(true);
		}
		else
		{
			YouSkiped.gameObject.SetActive(false);
		}


	}
	void AdERROR()
	{
		AdErrorScreen.gameObject.SetActive(true);

	}




	public void ReviveCharacter()
	{
	
		AdErrorScreen.gameObject.SetActive(false);

	}



}
