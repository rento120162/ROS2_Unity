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
Make sure Unity editor version is later than 2022.3.xx
<img width="1164" height="806" alt="Screenshot from 2026-03-09 16-58-20" src="https://github.com/user-attachments/assets/8dffd198-c493-4802-afad-413ac9300c4b" />

Switch build platform from PC to Android
<img width="1393" height="806" alt="Screenshot from 2026-03-09 16-59-06" src="https://github.com/user-attachments/assets/6bccd371-866f-4f2d-8ba3-6fc1485a5ca1" />

Install XR Plugin Management 
<img width="1393" height="806" alt="Screenshot from 2026-03-09 16-59-53" src="https://github.com/user-attachments/assets/2c84509c-fae4-4c12-9c59-74b7019d6673" />

Put check mark onto Oculus
<img width="1393" height="806" alt="Screenshot from 2026-03-09 17-00-17" src="https://github.com/user-attachments/assets/772d4564-8516-4182-9de7-32f89b67f985" />

Chenge build setting for Android
<img width="1393" height="806" alt="Screenshot from 2026-03-09 17-01-01" src="https://github.com/user-attachments/assets/f81b320b-f1d5-40e4-ba69-b976a6053a00" />

Make sure to import package "for Oculus"
```bash


```
<img width="1393" height="806" alt="Screenshot from 2026-03-09 17-01-17" src="https://github.com/user-attachments/assets/26749a62-78db-46b1-8bd2-a32fe63a0fb2" />



Attach 2 script to Gameobject 
(1. ROS2 Unity Component: essential for ROS2-Unity communication
2. ROS2 Tolker Example: publish timestamp to "/chatter" topic that could read from anyone in the same network) 
<img width="1734" height="914" alt="Screenshot from 2026-03-09 17-01-51" src="https://github.com/user-attachments/assets/4ced1da2-137a-4f85-9878-bd82033658e1" />


If PC is connected to Oculus that is set developper mode , it appers here
<img width="1734" height="914" alt="Screenshot from 2026-03-09 17-02-30" src="https://github.com/user-attachments/assets/3fe8ed92-f74e-4f14-bd74-5fbc850aa899" />



Build and run
and then you can recieve topic from Oculus
<img width="788" height="912" alt="Screenshot from 2026-03-09 17-03-49" src="https://github.com/user-attachments/assets/23038745-b094-49ba-93d0-0856ec41e409" />






