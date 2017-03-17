using UnityEngine;
using System.Collections;

public abstract class Gun : MonoBehaviour{
    public GameObject bullet;
    public GameObject parent;
    public float rof;
    public float accuracy;
    public void Start() {
        if (parent == null)
            parent = transform.parent.gameObject;

    }
    public void setParent(GameObject parent){
        this.parent = parent;
    }
    protected float nextFireTime = 0;
    public abstract void fire(Vector2 origin, Quaternion direction);
    public abstract void fireCont(Vector2 origin, Quaternion direction);
}