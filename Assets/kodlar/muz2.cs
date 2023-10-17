using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class muz2 : MonoBehaviour
{

    Vector3 pos;
    Camera _camera;
    public static bool isinside = false;
    public GameObject[] ikinci_satir;
    public TextMeshProUGUI text;



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

            ikinci_satir[0].SetActive(true);
            ikinci_satir[1].SetActive(true);
            ikinci_satir[2].SetActive(true);
            ikinci_satir[3].SetActive(false);
            text.text = "Çok iyisin. Robot bu işlemi bizim için kolaylaştırdı. Sen de işlemin kalan kısmını yap!";
            //ikinci_satir[4].SetActive(true);

        }
        else
        {
            Vector3 worldPos = _camera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(worldPos.x, worldPos.y, 0);
        }



    }
    }
