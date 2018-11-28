using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTurret : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private GameObject blueBulletPrefab;
    [SerializeField] private Transform blueNozzle;

    //GameObject blue;
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
        if (Input.GetMouseButtonDown(0))
            shoot();
    }

    void faceMouse()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y);

        transform.right = direction;
    }

    void shoot()
    {
        GameObject blue = Instantiate(blueBulletPrefab, blueNozzle.position, transform.rotation);
        blue.transform.GetChild(0).GetComponent<Rigidbody2D>().velocity = transform.right * bulletSpeed;
        Destroy(blue, 2f);
    }


}
