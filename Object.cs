using OpenTK.Graphics.OpenGL4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3dRender
{
    internal class Object
    {
        enum VERTEX
        {
            POSITION,
            COLOR
        }
        private int _vertexBufferObject; // Handle
        private int _vertexArrayObject; // 
        private float[] _data = { -0.5f, -0.5f, 0.0f,
        0.5f, -0.5f, 0.0f, 0.0f, 0.5f, 0.0f, };


        public Object()
        {
            
        }

        public void draw()
        {
            GL.BindVertexArray(_vertexArrayObject);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
        }

        public void load()
        {
            _vertexBufferObject = GL.GenBuffer();
            // Points to the active buffer
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            // Insert the data into the buffer
            GL.BufferData(BufferTarget.ArrayBuffer, _data.Length * sizeof(float), _data, BufferUsageHint.StaticDraw);

            // Generte the array object buffer
            _vertexArrayObject = GL.GenVertexArray();
            // points to the array object
            GL.BindVertexArray(_vertexArrayObject);

            // creates an attribute pointer
            GL.VertexAttribPointer((int)VERTEX.POSITION, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), (int)VERTEX.POSITION);

            GL.EnableVertexAttribArray(0);        }
    }// 
}
