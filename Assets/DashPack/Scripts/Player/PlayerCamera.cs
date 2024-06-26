using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    [SerializeField] private float topClamp = 2.5f;
    [SerializeField] private float bottomClamp = 3.5f;

    private float y;
    void Update() {
        y = Mathf.Clamp( transform.position.y, player.position.y - topClamp, player.position.y + bottomClamp );
        transform.position = new Vector3( player.position.x, 0f, -10f ) + offset;
    }

}
