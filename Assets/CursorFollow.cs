using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorFollow : MonoBehaviour
{

    Vector2 MousePosition;
    public GameObject Bullet;
    public Transform shotPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log(MousePosition);
        transform.LookAt(MousePosition, Vector3.left);
        transform.Rotate(0, 90, 0);


        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet, shotPoint.position, shotPoint.transform.rotation);
        }
    }
}
