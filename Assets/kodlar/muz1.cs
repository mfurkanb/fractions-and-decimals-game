using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class muz1 : MonoBehaviour
{

    Vector3 pos;
    Camera _camera;
    public static bool isinside = false;
    public GameObject[] ilk_satir;



    // Start is called before the first frame update
    void Start()
    {
        _camera = Camera.main;
        pos = this.transform.position;
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

        if (collider.gameObject.tag == "makine")
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

            ilk_satir[0].SetActive(true);
            ilk_satir[1].SetActive(true);
            ilk_satir[2].SetActive(true);
            ilk_satir[3].SetActive(true);
            ilk_satir[4].SetActive(false);

        }
        else
        {
            Vector3 worldPos = _camera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(worldPos.x, worldPos.y, 0);
        }




    }
}
