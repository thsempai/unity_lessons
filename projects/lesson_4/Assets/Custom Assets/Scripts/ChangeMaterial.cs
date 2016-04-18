using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {

	// Use this for initialization
	void Start () {
	Material solasSkull = (Material)Resources.Load("Solas skull");
    GetComponent<Renderer>().material = solasSkull;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
