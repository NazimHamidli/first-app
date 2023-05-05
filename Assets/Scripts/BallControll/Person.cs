using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person
{
   private string _name;
    public float hieght;
    private float weight = 80;

    public float Weight
    {
        set
        {
            weight = value - 20;
        }
        get
        {
            weight *= 2;
            return weight;
        }
    }


    //public string GetPersonName()
    //{
    //    return _name;
    //}

    //void Start()
    //{
    //    //Debug.Log(Weight);
    //    //Weight = 91;
    //    //Debug.Log(Weight);

    //    //SetHeight();
    //}

    public void SetHeight()
    {
        hieght = 1.80f;
    }
    void SetHeight(float height)
    {
        hieght = height;
    }
    void SetHeight(float height,string str)
    {
        hieght = height;
    }
}
