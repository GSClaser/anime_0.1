using UnityEngine;
using System.Collections;

public class main : MonoBehaviour {
	public Animator animator;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI()
	{
		if(GUI.Button(new Rect(0, 0, 100, 50), "idle")){
			animator.Play ("idle");
		}
		if(GUI.Button(new Rect(0, 100, 100, 50), "walk")){
			animator.Play ("walk");
		}
		if(GUI.Button(new Rect(0, 200, 100, 50), "run")){
			animator.Play ("run");
		}
		if(GUI.Button(new Rect(0, 300, 100, 50), "attack")){
			animator.Play ("strike");
		}

	}
}
