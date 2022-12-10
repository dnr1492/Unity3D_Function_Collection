using UnityEngine;

public class ARView : MonoBehaviour
{
    protected MainScene mainScene;

    protected virtual void Awake()
    {
        mainScene = FindObjectOfType<MainScene>();
    }
}
