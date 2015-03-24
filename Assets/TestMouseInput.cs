using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestMouseInput : MonoBehaviour {

    Text textElement;

	// Use this for initialization
	void Start () {

        textElement = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 position = Input.mousePosition;
        position.Scale(new Vector2(1f / Screen.width, 1f / Screen.height));
        textElement.text = string.Format("{0}", position);
	}
}
