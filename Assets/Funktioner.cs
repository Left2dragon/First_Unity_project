using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funktioner : MonoBehaviour {

    public bool IsChecked;
    public int MyIntValue = 10;
    public int userValue;

	// Use this for initialization
	void Start ()
    {
		if (IsChecked == true)
        {
            Debug.Log("It's true");
        }
        else
        {
            Debug.Log("It's False");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        // == Lika med
        // != inte lika med
        // <= mindre än eller lika med
        // >= större än eller lika med
        // < mindre än
        // > större än
        // && och
        // Eller (or) [alt gr + <]

        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            print("reload");
        }
        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            MyIntValue = Random.Range(0, 10);
            print(Random.Range(0f, 10f));
            print("Lean Left");
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            print(userValue += 2);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print(userValue /= 2);
        }

	}
}
