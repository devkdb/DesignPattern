using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory : MonoBehaviour {

    static Dictionary<string, Marine> dic = new Dictionary<string, Marine>();

    public static Marine getPerson(string name)
    {
        if (!dic.ContainsKey(name))
        {
            Marine tmp = new Marine(name);
            dic.Add(name, tmp);
        }
        return dic[name];
    }
}

