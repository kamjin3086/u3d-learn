using UnityEngine;

public class MobileControlsEnabler : MonoBehaviour
{
    void Awake()
    {
        // 我们使用预处理器指令
        // 如果平台不是 ANDROID 也不是 IOS...
#if !UNITY_ANDROID && !UNITY_IOS
        // ...就把这个物体（和它的所有子物体）隐藏掉。
        gameObject.SetActive(false);
#endif
    }
}