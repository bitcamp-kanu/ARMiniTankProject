using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class TankMove : MonoBehaviour {

    //탱크의 이동 및 회전 속도를 나타내는 변수
    public float moveSpeed = 20.0f;
    public float rotSpeed = 50.0f;

    //참조할 컴포넌트를 할당할 변수
    private Rigidbody rbody;
    private Transform tr;
   
    //키보드 입력값 변수
    private float h, v;

    //PhotonView 컴포넌트를 할당할 변수
    private PhotonView pv = null;

    //메인 카메라가 추적할 CamPivot 게임오브젝트
    public Transform camPivot;

	void Start () {
        //컴포넌트 할당
        rbody = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();

        //Rigidbody의 무게중심을 낮게 설정
        rbody.centerOfMass = new Vector3(0.0f, -0.5f, 0.0f);

        //PhotonView 컴포넌트 할당
        pv = GetComponent<PhotonView>();

        //PhotonView가 자신의 탱크일 경우
        if (pv.isMine)
        {
            //메인 카메라에 추가된 SmoothFollow 스크립트에 추적 대상을 연결
            Camera.main.GetComponent<SmoothFollow>().target = camPivot;

            //Rigidbody의 무게 중심을 낮게 설정
            rbody.centerOfMass = new Vector3(0.0f, -0.5f, 0.0f);
        }else
        {
            //원격 네트워크 플레이어의 탱크는 물리력을 이용하지 않음
            rbody.isKinematic = true;
        }

	}
	
	void Update () {
        //자신이 만든 네트워크 게임오브젝트가 아닌 경우는 키보드 조작 루틴을 나감
        if (!pv.isMine) return;

        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        //회전과 이동 거리
        tr.Rotate(Vector3.up * rotSpeed * h * Time.deltaTime);
        tr.Translate(Vector3.forward * v * moveSpeed * Time.deltaTime);
	}
}
