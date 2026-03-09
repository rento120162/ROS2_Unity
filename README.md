[![ros2 workflow](https://github.com/hrjp/rosenv/actions/workflows/ros2-humble-image-build.yml/badge.svg)](https://hub.docker.com/repository/docker/hrjp/ros2)

![license](https://img.shields.io/github/license/KobeKosenRobotics/rosenv_for_unitree)
![size](https://img.shields.io/github/repo-size/KobeKosenRobotics/rosenv_for_unitree)
![commit](https://img.shields.io/github/last-commit/KobeKosenRobotics/rosenv_for_unitree/main)

# ROS2_Unity
Communicate between ROS2 and Unity on PC or Android or Oculus Quest

Tested systems and ROS2 distro
- Ubuntu 22.04
- ROS2 Humble
- Unity editor 2022.3.62f3 or later

# References
- [https://qiita.com/hiro-han/items/a28f8e86c175c2765056](https://qiita.com/hiro-han/items/a28f8e86c175c2765056)
- [https://github.com/RobotecAI/ros2-for-unity](https://github.com/RobotecAI/ros2-for-unity)
- [https://github.com/Kotakku/ros2-for-unity-android-package](https://github.com/Kotakku/ros2-for-unity-android-package)
- [https://qiita.com/Kotakku/items/cdc3eca89dd8aec4ee86](https://qiita.com/Kotakku/items/cdc3eca89dd8aec4ee86)

# Setup
## 1.Make ROS container
```bash
git clone https://github.com/KobeKosenRobotics/rosenv.git
or If you use Jetson, choose below repo 
# git clone https://github.com/KobeKosenRobotics/rosenv_for_unitree
```
Follow to the README of below to learn How to make container [https://github.com/KobeKosenRobotics/rosenv.git](https://github.com/KobeKosenRobotics/rosenv.git)

## 2.Install essential packages to docker
```bash
sudo apt update
sudo apt install locales
sudo locale-gen en_US en_US.UTF-8
sudo update-locale LC_ALL=en_US.UTF-8 LANG=en_US.UTF-8
export LANG=en_US.UTF-8

sudo apt install software-properties-common curl

sudo curl -sSL https://raw.githubusercontent.com/ros/rosdistro/master/ros.key \
  -o /usr/share/keyrings/ros-archive-keyring.gpg

echo "deb [arch=$(dpkg --print-architecture) \
signed-by=/usr/share/keyrings/ros-archive-keyring.gpg] \
http://packages.ros.org/ros2/ubuntu \
$(. /etc/os-release && echo $UBUNTU_CODENAME) main" | \
sudo tee /etc/apt/sources.list.d/ros2.list > /dev/null

sudo apt update
sudo apt upgrade

sudo apt install patchelf
sudo apt install dotnet-sdk-6.0
```
```bash
echo 'export ROS_DISTRO=humble' >> ~/.bashrc
echo 'export RMW_IMPLEMENTATION=rmw_fastrtps_cpp ' >> ~/.bashrc
source ~/.bashrc
```
```bash
sudo apt install ros-$ROS_DISTRO-rmw-cyclonedds-cpp
sudo apt install ros-$ROS_DISTRO-rosidl-generator-dds-idl
sudo apt install libyaml-cpp-dev
```

```bash
source /opt/ros/humble/setup.bash

```

## 3.Create Unity projects
```bash

```
<img width="1164" height="806" alt="Screenshot from 2026-03-09 16-58-20" src="https://github.com/user-attachments/assets/fd3aed3f-7033-481a-84e1-351485addc02" />

