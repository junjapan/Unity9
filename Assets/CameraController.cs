using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    private void LateUpdate()
    {
        //        transform.position = player.position + (-player.forward * 3.0f) + (player.up * 1.0f);
        //以下で、カメラと対象の距離を決める。
        transform.position =
                    Vector3.Lerp(transform.position,
                    player.position + (-player.forward * 3.0f)
                    + (player.up * 1f), Time.deltaTime * 10f);
        //以下はカメラの向きを決める。
        //カメラのみる方向はZ軸になる。LookAtで対象の中心に向ける。中心だと腰くらいなので、Vector3.upで少し上を対象にする。
        transform.LookAt(player.position + Vector3.up);
    }
}
