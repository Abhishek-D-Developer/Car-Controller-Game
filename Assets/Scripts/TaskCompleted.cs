﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskCompleted : MonoBehaviour {

	public GameObject loadingScreen;

	public void LoadLevel (int sceneIndex)
	{
		StartCoroutine (LoadAsynchronously (sceneIndex));
	}
	IEnumerator LoadAsynchronously (int sceneIndex)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);
		yield return null;
	}
}
