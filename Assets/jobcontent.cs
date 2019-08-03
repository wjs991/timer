using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jobcontent : MonoBehaviour
{
    // Start is called before the first frame update
    public List<float> child = new List<float>();
    public List<string> child_name = new List<string>();
    public List<GameObject> child_obj = new List<GameObject>();
    public int index;
    public Button edit;
    public Button delete;
    public Button Go_;
    public bool open;
    public GameObject input_;
    public GameObject button_OK;
    public string name_obj;
    public Text name_job;
    public Button Add_button;
    void Start()
    {
        open = false;
        //go_1
        //delete_2
        //edit_3
        Go_ = this.transform.GetChild(1).GetComponent<Button>();
        delete = this.transform.GetChild(2).GetComponent<Button>();
        edit = this.transform.GetChild(3).GetComponent<Button>();
        
        this.GetComponent<Button>().onClick.AddListener(edit_list);
        Go_.onClick.AddListener(go_);
        delete.onClick.AddListener(delete_);
        edit.onClick.AddListener(edit_name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void edit_list()
    {
        if (open)
        {
            open = false;
            Go_.gameObject.SetActive(true);
            Add_button.gameObject.SetActive(false);
            for (int i = 0; i < child.Count; i++)
            {
                Destroy(child_obj[i]);
                
            }
            child_obj.Clear();
        }
        else
        {
            open = true;
            Go_.gameObject.SetActive(false);
            Add_button.gameObject.SetActive(true);
            //edit.gameObject.SetActive(false);
            for (int i = 0; i < child.Count; i++)
            {
                GameObject c_C = Instantiate(Resources.Load("job") as GameObject);
                c_C.transform.SetParent(this.transform.parent);
                c_C.transform.SetSiblingIndex(index + i + 1);
                c_C.transform.localScale = new Vector3(1, 1, 1);
                c_C.GetComponent<job_list_con>().index = i;
                c_C.GetComponent<job_list_con>().time.text = child[i].ToString();
                //c_C.GetComponent<job_list_con>().title.text = child_name[i].ToString();
                child_obj.Add(c_C);
            }
        }
        
    }

    public void delete_()
    {
        //하위 객체 까지 모두 삭제
        if (open)
        {
            for(int i = 0; i < child.Count; i++)
            {
                Destroy(child_obj[i]);
            }

        }
        Destroy(this.gameObject);
    }
    
    public void go_()
    {
        //타이머 시작
        //더 큰곳에서 담당
    }

    public void edit_name()
    {
        name_job.gameObject.SetActive(false);
        input_.SetActive(true);
        button_OK.SetActive(true);
    }

    public void ok_edit()
    {
        name_job.text = input_.GetComponent<InputField>().text;
        input_.SetActive(false);
        button_OK.SetActive(false);
        name_job.gameObject.SetActive(true);
    }

    public void Add_list()
    {
        
        GameObject c_C = Instantiate(Resources.Load("job") as GameObject);
        c_C.transform.SetParent(this.transform.parent);
        c_C.transform.SetSiblingIndex(index + child.Count);
        c_C.transform.localScale = new Vector3(1, 1, 1);
        child_obj.Add(c_C);
        child.Add(33f);
    }
}
