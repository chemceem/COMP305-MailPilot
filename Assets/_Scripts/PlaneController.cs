using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {

    //PRIVATE INSTANCE VARIABLES
    private float _playerInput;
    private Transform _transform;
    private Vector2 _currentPosition;

    //PUBLIC INSTANCE VARIABLES
    public float speed = 5f;

    // Use this for initialization
    void Start () {
        this._transform = gameObject.GetComponent<Transform>();
    }
    
    // Update is called once per frame
    void Update () {

        this._currentPosition = this._transform.position;
        this._playerInput = Input.GetAxis("Horizontal");

        if (this._playerInput > 0)
        {
            this._currentPosition += new Vector2(this.speed, 0);
        }

        if (this._playerInput < 0)
        {
            this._currentPosition -= new Vector2(this.speed, 0);
        }

        this._transform.position = this._currentPosition;
        Debug.Log(_playerInput);
    }

}
