# Sparrow
Sparrow is a game engine framework built in C#.
Sparrow is intended to be run and consumed by .net core applications.

The core design philosophy behind Sparrow supports the idea of quiet, modular components.
The design focuses around not forcing design choices onto the programmer.
Game engines such as unreal and unity force to write your code their way.
Sparrow instead provides a set of modular components.

# Progress
As I'm sure you'll plainly see, Sparrow is still in early stages.
It is a proof of concept.
Using `Sparrow.Application` as an entry point generates a window with an OpenGL context using SDL2.

# Roadmap

My next steps will be to flesh out the graphics layer.
Currently the OpenGL wrapper uses unsafe code, that will be going.
I also intend to implement input handling and collision detection.
I am also considering options regarding a hierarchy structure and a component model.
