using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelector : MonoBehaviour {

	public GameObject car;
	public GameObject Tocus;
	public GameObject Bmw;

	public int carSelected;

	void Start () {
		Tocus.SetActive (true);
		car.SetActive (false);
		Bmw.SetActive (false);	

		carSelected = 1;
	}
	
	public void Loadcar()
	{
		Tocus.SetActive (true);
		car.SetActive (false);
		Bmw.SetActive (false);	

		carSelected = 1;
	}

	public void LoadTocus()
	{
		Tocus.SetActive (false);
		car.SetActive (true);
		Bmw.SetActive (false);	

		carSelected = 2;
	}

	public void LoadBmw()
	{
		Tocus.SetActive (false);
		car.SetActive (false);
		Bmw.SetActive (true);	

		carSelected = 3;
	}
}
