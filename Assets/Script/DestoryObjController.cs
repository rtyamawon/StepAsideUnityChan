using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryObjController : MonoBehaviour {

	    //Unityちゃんのオブジェクト
        private GameObject unitychan;
        //Unityちゃんとカメラの距離
        private float difference;

	// Use this for initialization
	void Start () {

			//Unityちゃんのオブジェクトを取得
			this.unitychan = GameObject.Find ("unitychan");
			//Unityちゃんとカメラの位置（z座標）の差を求める
			this.difference = unitychan.transform.position.z - this.transform.position.z;

	}
	
	// Update is called once per frame
	void Update () {
		 //Unityちゃんの位置に合わせ位置を移動
         this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);
	}
          //トリガーモードで他のオブジェクトと接触した場合の処理（追加）
	void OnTriggerEnter(Collider other) {
		Debug.Log(other.gameObject.tag);
					//接触したコインのオブジェクトを破棄（追加）
					Destroy (other.gameObject);
	}
}
