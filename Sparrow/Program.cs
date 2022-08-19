using static Sparrow.Glfw.Lib;

if (glfwInit() == GLFW_FALSE) return;

glfwWindowHint(GLFW_CLIENT_API, GLFW_NO_API);
glfwWindowHint(GLFW_RESIZABLE, GLFW_FALSE);

var window = glfwCreateWindow(800, 600, "Vulkan", GLFWmonitor.Zero, GLFWwindow.Zero);

while(glfwWindowShouldClose(window) == GLFW_FALSE)
{
    glfwPollEvents();
}

glfwDestroyWindow(window);
glfwTerminate();