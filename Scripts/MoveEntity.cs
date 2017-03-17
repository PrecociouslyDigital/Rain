using UnityEngine;
using System.Collections;

public class MoveEntity : Entity {
    public float speed;
    public GameObject[] guns;
    private byte currentGunIndex = 0;
    private Gun currentGun;
    protected Rigidbody2D body;
    protected virtual void Start() {
        body = gameObject.GetComponent<Rigidbody2D>();
        GameObject temp = (GameObject)GameObject.Instantiate(guns[currentGunIndex],transform.position,transform.rotation);
        temp.transform.parent = transform;
        currentGun = temp.GetComponent<Pistol>();
    }
    protected void moveTowards(Vector2 target) {
        body.velocity = target.normalized * speed;
        lookAt(target);
    }
    protected void lookAt(Vector2 target) {
        if (target.Equals(Vector2.zero))
            return;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Rad2Deg * Mathf.Atan(target.y / target.x) + (target.x < 0 ? 90 : -90)));
    }
    protected void shoot() {
        currentGun.fire(transform.position, transform.rotation);
    }
    protected void shoot(Vector2 target) {
        currentGun.fire(transform.position, Quaternion.Euler(new Vector3(0, 0, Mathf.Rad2Deg * Mathf.Atan(target.y / target.x) + (target.x < 0 ? 90 : -90))));
    }
}