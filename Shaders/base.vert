// Hint to specify opengl version
#version 400

// Giver a name (Position) to the data in the 0 layout
layout(location = 0) in vec3 Position;

// Entry point
void main(void)
{
    gl_Position = vec4(Position * 0.5, 1.0);
}