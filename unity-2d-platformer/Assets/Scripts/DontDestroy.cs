/// 000314083 Jordan Marshall

using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
