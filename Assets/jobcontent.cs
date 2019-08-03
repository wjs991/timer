using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jobcontent : MonoBehaviour
{
    // Start is called before the first frame update
    public List<float> child = new List<float>();
    public int index;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void edit_list()
    {
        for(int i = 0; i < child.Count; i++)
        {
            GameObject c_C = Instantiate(Resources.Load("job") as GameObject);
            c_C.transform.SetParent(this.transform.parent);
            c_C.transform.SetSiblingIndex(index + i + 1);
            c_C.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
