using UnityEngine;
using System.Collections;

public class OceanController : MonoBehaviour {

	//PRIVATE INSTANCE VARIABLE
	private Transform _transform;
    private Vector2 _currentPosition;

    //PUBLIC INSTANCE VARIABLES
    public float speed = 5;

	// Use this for initialization
	void Start () {
        //make a reference with the transform component
		this._transform = gameObject.GetComponent<Transform>();

        //reset the ocean sprite to the top
        this.Reset();
	}
	
	// Update is called once per frame
	void Update () {
        this._currentPosition = this._transform.position;
        this._currentPosition -= new Vector2(0, speed);
        this._transform.position = this._currentPosition;

        if (this._currentPosition.y <= -480) { Reset();}
	}

    void Reset() {
        this._transform.position = new Vector2(0, 480f);
    }
}
