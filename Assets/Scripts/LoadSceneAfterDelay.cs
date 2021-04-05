using UnityEngine;
using System.Collections;

public class LoadSceneAfterDelay : MonoBehaviour {
	// Use this for initialization
	void Start () {
		StartCoroutine (loadSceneAfterDelay (1));
	}

	IEnumerator loadSceneAfterDelay(float waitbySecs){
		yield return new WaitForSeconds(waitbySecs);
		Application.LoadLevel (1);
	} 

	// Update is called once per frame
	void Update () {

	}
}