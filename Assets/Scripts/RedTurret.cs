using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTurret : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private GameObject redBulletPrefab;
    [SerializeField] private Transform redNozzle;

    private Vector3 mousePosition;
    // Use this for initialization
    void Start()
    {
        //Just another Start Function ;)
    }

    // Update is called once per frame
    void Update()
    {
        faceMouse();
        if (Input.GetMouseButtonDown(1))
            shoot();
    }

    void faceMouse()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y);

        transform.right = -direction;
    }

    void shoot()
    {
        GameObject red = Instantiate(redBulletPrefab, redNozzle.position, transform.rotation);
        red.transform.GetChild(0).GetComponent<Rigidbody2D>().velocity = -transform.right * bulletSpeed;
        Destroy(red, 2f);
    }
}
