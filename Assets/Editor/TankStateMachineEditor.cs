// ����Ƽ �ν����Ϳ��� TankStateMachine ������Ʈ�� �������� ��, 
// �⺻ �ν����� ��� �ش� �ڵ忡�� ������ ������� UI�� �����ְ� �ȴ�.

using UnityEditor;

[CustomEditor(typeof(TankStateMachine))]    // TankStateMachine ������Ʈ�� Ŀ���� �ν����͸� ������.
public class TankStateMachineEditor : Editor
{
    SerializedProperty _initialStateProp;
    SerializedProperty _enemyRegistryProp;

    Editor _initialStateSOEditor;

    private void OnEnable()
    {
        _initialStateProp = serializedObject.FindProperty("_initialState");     // TankStateMachine �ν��Ͻ� ������ _initialState �ʵ带 ã�� ����
        _enemyRegistryProp = serializedObject.FindProperty("_enemyRegistry");   // TankStateMachine �ν��Ͻ� ������ _enemyRegistry �ʵ带 ã�� ����
    }

    // �ν����� ã�� �׷��� ������ ȣ��Ǵ� �Լ�
    // ��, ���⼭ �ν����� UI�� ���� ����
    public override void OnInspectorGUI()
    {
        serializedObject.Update();                                      // �ν������� �ֽ� ���� �ݿ�
        EditorGUILayout.PropertyField(_initialStateProp);               // _initialState �ʵ带 �ν����Ϳ� ǥ��

        // _initialState�� ����� TankStateSO�� �ִٸ�. �� ��ũ���ͺ� ������Ʈ�� �ν����� ���뵵 �ٷ� �Ʒ��� ǥ��
        // ��, TankStateMachine �ν����Ϳ��� _initialState �ʵ带 ������ ��, �� TankStateSO ���� ������� �ٷ� ������ �� �ִ� UI�� ǥ��
        // ���� ��ũ���ͺ� ������Ʈ�� ������ ������ Ŭ���ؾ� ���� �����ѵ�, �� �ڵ� ���п� �� �ν����Ϳ��� �ٷ� ���� ������
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

        EditorGUILayout.PropertyField( _enemyRegistryProp);                 // _enemyRegistry�� �⺻ �ν����� ���·� ǥ��
        serializedObject.ApplyModifiedProperties();                         // �ν����Ϳ��� ����� ���� ���� ��ü�� �ݿ�
    }

    // �����Ͱ� ��Ȱ��ȭ�� ��, _initialStateSOEditor�� ������. 
    // �׷��� ������ �����Ͱ� �޸𸮸� ��� �����ϰų� �߸��� ������ ������ �� ����
    private void OnDisable()
    {
        if (_initialStateSOEditor != null)
            DestroyImmediate(_initialStateSOEditor);
    }
}
