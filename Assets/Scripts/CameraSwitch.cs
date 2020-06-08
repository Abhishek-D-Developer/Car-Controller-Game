using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour {

	public Camera cam1;
	public Camera cam2;
	public Camera cam3;
	public Camera cam4;

	public void switchcam(int x)
	{
		deactivatell ();
		if (x == 1) {
			cam1.enabled = true;
		} else if (x == 2) {
			cam2.enabled = true;
		} else if (x == 3) {
			cam3.enabled = true;
		} else {
			cam4.enabled = true;
		}
	}
	public void deactivatell()
	{
		cam1.enabled = false;
		cam2.enabled = false;
		cam3.enabled = false;
	}
}
