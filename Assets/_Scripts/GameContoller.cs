using UnityEngine;
using System.Collections;

public class GameContoller : MonoBehaviour {

	//PUBLIC INSTANCE VARIABLES
	public int cloudNumber = 3;    
    public CloudController cloud;
	
	// Use this for initialization
	void Start () {
        this._initialize();        

	}
	
	// Update is called once per frame
	void Update () {        
    }	

	//***** Private methods *****
	private void _initialize()	{
        for (int cloudCount = 0; cloudCount < this.cloudNumber; cloudCount++)
        {			
            Instantiate(cloud.gameObject);
        }
	}
}
