using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCannon : MonoBehaviour {

    //cannon 프리팹을 연결할 변수
    public GameObject cannon = null;

    //cannon 발사 지점
    public Transform firePos;

    //포탄 발사 사운드 파일
    private AudioClip fireSfx = null;

    //AudioSource 컴포넌트를 할당할 변수
    private AudioSource sfx = null;

	void Awake () {
        //cannon 프리팹을 Resources 폴더에서 불러와 변수에 할당
        cannon = (GameObject)Resources.Load("Cannon");

        //포탄 발사 사운드 파일을 Resources 폴더에서 불러와 변수에 할당
        fireSfx = Resources.Load<AudioClip>("Cannonfire");

        //AudioSource 컴포넌트를 할당
        sfx = GetComponent<AudioSource>();
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

        //발사 사운드 발생
        sfx.PlayOneShot(fireSfx, 2.0f);
    }
}
