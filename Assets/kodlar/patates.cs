using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patates : MonoBehaviour
{

    Vector3 pos;
    Camera _camera;
    public static bool isinside = false;
    public SpriteRenderer onda;
    public GameObject buton;
    public GameObject uc;
    public GameObject iki;


    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        pos = this.transform.position;
        onda = onda.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDrag()
    {
        Vector3 worldPos = _camera.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(worldPos.x, worldPos.y, 0);
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.gameObject.tag == "robot")
        {
            isinside = true;

        }
        else
        {
            isinside = false;
        }

    }
    private void OnMouseUp()
    {
        if (isinside)
        {
            
            onda.color = Color.green;
            buton.gameObject.SetActive(true);
            uc.SetActive(true);
            iki.SetActive(true);

        }
        else
        {
            Vector3 worldPos = _camera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(worldPos.x, worldPos.y, 0);
        }




    }
}
