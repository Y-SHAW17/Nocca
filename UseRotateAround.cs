using UnityEngine;

/// <summary>
/// Transform.RotateAroundを用いた円運動
/// </summary>
public class UseRotateAround : MonoBehaviour
{
    // 中心点
    [SerializeField] private Vector3 center = new Vector3(0, 0, 0);

    // 回転軸
    [SerializeField] private Vector3 axis = Vector3.up;

    // 円運動周期
    [SerializeField] private float period = 2;

    private void Update(){
				if (Input.GetKey (KeyCode.A)) {
            this.transform.RotateAround(center, axis, 360 / period * Time.deltaTime);
        }
				if (Input.GetKey (KeyCode.D)) {
            this.transform.RotateAround(center, axis, - 360 / period * Time.deltaTime);
        }
    }
}
