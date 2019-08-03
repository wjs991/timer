using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class record_content : MonoBehaviour
{
    public int index;
    public float time;
    public string name_timer;
    public timer upper;
    public GameObject center;
    public GameObject record_menu;
    public GameObject input_f;
    public GameObject go;
    public GameObject delete;
    public GameObject edit;
    public GameObject OK;
    public Text name_timer_ui;
    public void record_go()
    {
        upper.s.value = time;
        upper.timer_text.text = (Mathf.Floor(upper.s.value * 60f)).ToString() + " 분";
        center.SetActive(true);
        record_menu.SetActive(false);
    }

    public void record_delete()
    {
        upper.record.RemoveAt(index);
        Destroy(this.gameObject);
    }

    public void edit_name()
    {
        go.SetActive(false);
        delete.SetActive(false);
        edit.SetActive(false);
        input_f.SetActive(true);
        OK.SetActive(true);
    }

    public void edit_OK()
    {
        name_timer = input_f.GetComponent<InputField>().text;
        name_timer_ui.text = name_timer;
        input_f.SetActive(false);
        OK.SetActive(false);
        go.SetActive(true);
        delete.SetActive(true);
        edit.SetActive(true);
    }
}
