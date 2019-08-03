using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class job_list_con : MonoBehaviour
{
    public int index;
    public string name_;
    public Text title;
    public Text time;
    public float timer;
    public Slider sli;
    public Button OK;
    public Button delete_;
    public Button edit;
    public GameObject Input_;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time.text = (Mathf.Floor(sli.value * 60f)).ToString() + " 분";
    }

    public void edit_mod()
    {
        OK.gameObject.SetActive(true);
        Input_.gameObject.SetActive(true);
        edit.gameObject.SetActive(false);
        sli.gameObject.SetActive(true);
    }

    public void OK_mod()
    {
        OK.gameObject.SetActive(false);
        Input_.gameObject.SetActive(false);
        edit.gameObject.SetActive(true);
        sli.gameObject.SetActive(false);
        title.text = Input_.GetComponent<InputField>().text;
    }

    public void delete_mod()
    {

    }
}
