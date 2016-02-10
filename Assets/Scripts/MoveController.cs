using UnityEngine;
using System.Collections;

public class MoveController : MonoBehaviour {

	public float speed = 1.0f;
	public float startPosition;
	public float endPosition;

	// Update is called once per frame
	void Update () {
		//毎フレームspeedの分左へ移動させる
		transform.Translate (-1.0f * speed * Time.deltaTime, 0, 0);

		//決めた座標まで行ったら移動を終わらせる
		if (transform.position.x < endPosition) {
			MoveEnd ();
		}
	}
	void MoveEnd () {
		//物体の座標をstartPositionに戻す
		transform.Translate (startPosition - endPosition, 0, 0);

		//同じゲームオブジェクトにアタッチされているコンポーネントにメッセージを送る
		SendMessage ("OnMoveEnd", SendMessageOptions.DontRequireReceiver);
	}
}
