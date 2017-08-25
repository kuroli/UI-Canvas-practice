using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public Text ResultText;
	// Use this for initialization
	void Start () {
        ResultText.text = "aa";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        ResultText.text = "bb";
    }
}
