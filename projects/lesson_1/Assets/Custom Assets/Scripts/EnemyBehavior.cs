using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour {

    public GameObject target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	GetComponent<NavMeshAgent>().destination = target.transform.position;
	}

    void OnCollisionEnter(Collision collision){
        SceneManager.LoadScene("lose");
    }
}
