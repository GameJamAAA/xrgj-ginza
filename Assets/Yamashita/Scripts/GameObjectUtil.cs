using UnityEngine;
using System.Collections.Generic;

public class GameObjectUtil {

    public static List<GameObject> GetChildren (GameObject obj) {
        var list = new List<GameObject>();
        for(int i = 0; i < obj.transform.childCount; i++) {
            list.Add(obj.transform.GetChild(i).gameObject);
        }
        return list;
    }

}
