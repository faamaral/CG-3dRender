using OpenTK.Graphics.OpenGL4;


namespace HelloWindow
{
    internal class Object
    {
        private const int POSITION = 0;
        private const int COLOR = 1;
        private const int UV = 3;

        private int _vertexBufferObject; // Handle
        private int _vertexArrayObject; // 
        private float[] _data = {
            -0.5f, -0.5f, 0.0f, // Vértice inferior esquerdo
            0.5f, -0.5f, 0.0f, // Vértice inferior direito
            0.0f, 0.5f, 0.0f, // Superior 
        };

        private float[] _colors =
        {
            1.0f, 0.0f, 0.0f, // Vértice inferior esquerdo
            0.0f, 0.0f, 1.0f, // Vértice inferior direito
            0.0f, 1.0f, 0.0f, // Superior
        };


        public Object()
        {

        }

        public void draw()
        {
            GL.BindVertexArray(_vertexArrayObject);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3); // Draw Call
        }

        public void load()
        {
            // Generate the buffer
            _vertexBufferObject = GL.GenBuffer();
            // Points to the active buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            // Insert the data into the buffer
            GL.BufferData(BufferTarget.ArrayBuffer, _data.Length * sizeof(float), _data, BufferUsageHint.StaticDraw);
            // Generate the array object buffer
            _vertexArrayObject = GL.GenVertexArray();
            // Points to the array object
            GL.BindVertexArray(_vertexArrayObject);
            // Creates an attribute pointer
            GL.VertexAttribPointer(POSITION, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), POSITION);
            GL.EnableVertexAttribArray(POSITION);
        }
    }// 
}
