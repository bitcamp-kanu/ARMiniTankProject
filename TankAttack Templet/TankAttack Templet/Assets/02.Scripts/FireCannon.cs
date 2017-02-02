using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannon : MonoBehaviour {

    //cannon 프리팹을 연결할 변수
    public GameObject cannon = null;

    //cannon 발사 지점
    public Transform firePos;

	void Awake () {
        //cannon 프리팹을 Resources 폴더에서 불러와 변수에 할당
        cannon = (GameObject)Resources.Load("Cannon");
	}
	
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
	}
    void Fire()
    {
        Instantiate(cannon, firePos.position, firePos.rotation);
    }
}
