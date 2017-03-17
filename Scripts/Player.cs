using UnityEngine;
using System.Collections;

public class Player : MoveEntity {
    double aimTime = 0;
	void Update () {
        Vector2 mousePos = (Vector2)Input.mousePosition - new Vector2(Screen.width, Screen.height);
        this.moveTowards(mousePos);
        if (Input.GetMouseButtonDown(0)) {
            this.shoot(mousePos);
            Debug.Log(mousePos);
        }
	}
}
