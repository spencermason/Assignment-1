using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCylindar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 move = Vector3.zero;
            move.x = 2;
            move.y = 5;
            move.z = 0;
            gameObject.transform.position = move;
        }
    }


}
