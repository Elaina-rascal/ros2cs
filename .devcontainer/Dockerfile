FROM elainasuki/ros:ros2-humble-full-v3

# 定义用户和用户组
ARG USERNAME=Elaina
WORKDIR /home/$USERNAME
RUN apt-get update && apt-get install -y dotnet-sdk-8.0 aspnetcore-runtime-8.0 zlib1g

USER root
#安装导航依赖

RUN echo "source /opt/ros/humble/setup.bash" >> /home/$USERNAME/.bashrc \
    && echo "export ROS_LOCALHOST_ONLY=1" >> /home/$USERNAME/.bashrc \
    && echo "export ROS_LOCALHOST_ONLY=1" >> /home/$USERNAME/.config/fish/config.fish 
CMD ["/bin/bash"]
