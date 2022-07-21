using UnityEditor;

namespace Labirint
{
    public class MenuItems
    {
        [MenuItem("GeekBrains/Пункт меню №1")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "GeekBrains");
        }
    }

}
