using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DataCenta", menuName = "ScriptableObject/Add_items", order = 1)]
public class Data : ScriptableObject
{
    public string name;
    public string description;
    public string type;
}
