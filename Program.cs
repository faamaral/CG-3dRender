using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace _3dRender
{
    public static class Program
    {

        private static void Main()
        {
            // Setting the window
            var _cfg = new NativeWindowSettings()
            {
                Size = new Vector2i(800, 600),
                Title = "Olá Triângulo",
                WindowBorder = WindowBorder.Fixed,
            };

            using (var window = new Window(GameWindowSettings.Default, _cfg)) { window.Run(); }
        }
    }
}
