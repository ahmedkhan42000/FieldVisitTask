using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShape : MonoBehaviour
{
    int Speed = 5;
    // Start is called before the first frame update
    void Start( )
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        ShapeChange();
    }
    public void Movement()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);

    }
    public void ShapeChange()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Find("Player").gameObject.SetActive(false);
            transform.Find("PlayerL").gameObject.SetActive(false);
            transform.Find("PlayerD").gameObject.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Find("PlayerL").gameObject.SetActive(true);
            transform.Find("Player").gameObject.SetActive(false);
            transform.Find("PlayerD").gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Debug.Log("Game End");
        }
    }
}
