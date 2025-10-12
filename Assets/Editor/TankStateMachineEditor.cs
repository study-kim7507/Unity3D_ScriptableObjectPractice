// 유니티 인스펙터에서 TankStateMachine 컴포넌트를 선택했을 때, 
// 기본 인스펙터 대신 해당 코드에서 정의한 방식으로 UI를 보여주게 된다.

using UnityEditor;

[CustomEditor(typeof(TankStateMachine))]    // TankStateMachine 컴포넌트의 커스텀 인스펙터를 정의함.
public class TankStateMachineEditor : Editor
{
    SerializedProperty _initialStateProp;
    SerializedProperty _enemyRegistryProp;

    Editor _initialStateSOEditor;

    private void OnEnable()
    {
        _initialStateProp = serializedObject.FindProperty("_initialState");     // TankStateMachine 인스턴스 내부의 _initialState 필드를 찾아 연결
        _enemyRegistryProp = serializedObject.FindProperty("_enemyRegistry");   // TankStateMachine 인스턴스 내부의 _enemyRegistry 필드를 찾아 연결
    }

    // 인스펙터 찾이 그려질 때마다 호출되는 함수
    // 즉, 여기서 인스펙터 UI를 직접 구성
    public override void OnInspectorGUI()
    {
        serializedObject.Update();                                      // 인스펙터의 최신 값을 반영
        EditorGUILayout.PropertyField(_initialStateProp);               // _initialState 필드를 인스펙터에 표시

        // _initialState에 연결된 TankStateSO가 있다면. 그 스크립터블 오브젝트의 인스펙터 내용도 바로 아래에 표시
        // 즉, TankStateMachine 인스펙터에서 _initialState 필드를 선택한 뒤, 그 TankStateSO 내부 값들까지 바로 수정할 수 있는 UI를 표시
        // 보통 스크립터블 오브젝트는 별도의 파일을 클릭해야 수정 가능한데, 이 코드 덕분에 한 인스펙터에서 바로 수정 가능함
        var soAsset = _initialStateProp.objectReferenceValue as TankStateSO;
        if (soAsset != null)
        {
            if (_initialStateSOEditor == null || _initialStateSOEditor.target != soAsset)
            {
                if (_initialStateSOEditor != null)
                    DestroyImmediate(_initialStateSOEditor);
                _initialStateSOEditor = Editor.CreateEditor(soAsset);
            }

            _initialStateSOEditor.OnInspectorGUI();
        }

        EditorGUILayout.PropertyField( _enemyRegistryProp);                 // _enemyRegistry도 기본 인스펙터 형태로 표시
        serializedObject.ApplyModifiedProperties();                         // 인스펙터에서 변경된 값을 실제 객체에 반영
    }

    // 에디터가 비활성화될 때, _initialStateSOEditor를 정리함. 
    // 그렇지 않으면 에디터가 메모리를 계속 점유하거나 잘못된 참조를 유지할 수 있음
    private void OnDisable()
    {
        if (_initialStateSOEditor != null)
            DestroyImmediate(_initialStateSOEditor);
    }
}
