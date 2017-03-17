using UnityEngine;
using System.Collections;

public class Pistol : Gun {
    public override void fire(Vector2 origin, Quaternion direction) {
        if (Time.time < nextFireTime)
            return;
        nextFireTime = Time.time + rof;
        GameObject.Instantiate(bullet).GetComponent<Bullet>().setUp(parent.transform.position, parent.transform.rotation, parent.layer);
    }
    public override void fireCont(Vector2 origin, Quaternion direction) {
         
    }
}
