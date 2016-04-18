using UnityEngine;
using System.Collections;

public class GenerateCapsule : MonoBehaviour {

    public Vector3 pinkPosition;
	// Use this for initialization
	void Start () {
	GameObject pink = (GameObject)Resources.Load("pink");
    Instantiate(pink, pinkPosition, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
