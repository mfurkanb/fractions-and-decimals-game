using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class yag : MonoBehaviour
{
    Vector3 pos;
    Camera _camera;
    public static bool isinside = false;
    public static bool isinside2 = true;
    public GameObject note_defteri;
   
    public TextMeshProUGUI text;
    public SpriteRenderer ust_bar;



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

        if (collider.gameObject.tag == "terazi" &&  isinside2)
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
            un.isinside2 = true;


            Vector3 worldPos = _camera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(worldPos.x, worldPos.y, 0);
            note_defteri.gameObject.SetActive(true);
            text.text = "Doğru, haydi devam et!";
            ust_bar.color = Color.green;


        }
        else
        {
            this.transform.position = new Vector3(pos.x,pos.y,pos.z);
            text.text = "Sanırım bir hata oldu, yağ 2.5 litre.";
            ust_bar.color = Color.red;
        }
    }
}
