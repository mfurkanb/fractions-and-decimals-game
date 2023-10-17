using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class seker : MonoBehaviour
{
    Vector3 pos;
    Camera _camera;
    public static bool isinside = false;
    public static bool isinside2 = false;
    public TextMeshProUGUI text;
    public SpriteRenderer ust_bar;
    public GameObject not;
    public GameObject not_defteri;
    


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

        if (collider.gameObject.tag == "terazi" && isinside2)
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

            isinside2 = false;
            not.SetActive(true);

            Vector3 worldPos = _camera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(worldPos.x, worldPos.y, 0);

            not_defteri.gameObject.SetActive(true);
            text.text = "Doğru, haydi devam et!";
            ust_bar.color = Color.green;

        }
        else
        {
            this.transform.position = new Vector3(pos.x, pos.y, pos.z);
            text.text = "Sanırım bir hata oldu, şeker 0.650 kg.";
            ust_bar.color = Color.red;
        }
    }
}
