using UnityEngine;
using System.Collections;

public class DestroyGameObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
