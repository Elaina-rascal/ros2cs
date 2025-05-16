using Rcl;
using Rcl.Logging;
// using Rosidl
await using var context = new RclContext(args);
using var node = context.CreateNode("my_ros2_node");
node.Parameters.Declare("pub_name", "test");
String name = node.Parameters.Get("pub_name").AsString();
// node.CreatePublisher<r>
node.Logger.LogInformation($"Hello ROS 2 {RosEnvironment.Distribution}!");