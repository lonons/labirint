using UnityEditor;

namespace Labirint
{
    public class MenuItems
    {
        [MenuItem("GeekBrains/����� ���� �1")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "GeekBrains");
        }
    }

}
