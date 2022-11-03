using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListString : MonoBehaviour
{
    public List<string> list = new List<string>(); //Make list in inspector.

    public void Start()
    {
        //DELETE LISTS THAT HAVE MORE THAN 5 LETTERS
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Length > 5)
            {
                list.RemoveAt(i);
            }
        }
    }
}