using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject logic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActiveTrue()
    {
        //logic.SetActive(true);
        logic.transform.position = new Vector3(0, -1, 9);
    }

    public void SetActiveFalse()
    {
        //logic.SetActive(false);
        logic.transform.position = new Vector3(15, -1, 9);
    }

    public void SetActiveTruePlayer()
    {
        //logic.SetActive(false);
        logic.transform.position = new Vector3(0, -3.5f, 8);
    } 

    public void SetActiveTrueVoltar()
    {
        //logic.SetActive(false);
        logic.transform.position = new Vector3(0, 3, 9);
    }

    public void exit()
    {
        Application.Quit();
    }

}
