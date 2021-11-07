using UnityEngine;

public class FollowObjectView : MonoBehaviour
{
    [SerializeField]
    private Transform fpsTransformView;
    [SerializeField]
    private Transform thirdPersonTransformView;
    [SerializeField]
    private bool isFpsView = true;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab))
            isFpsView = !isFpsView;
        
        transform.position = isFpsView ? fpsTransformView.position : thirdPersonTransformView.position;
    }
}
