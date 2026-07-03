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
## 1.Create Unity projects
Make sure Unity editor version is later than 2022.3.xx
<img width="1164" height="806" alt="Screenshot from 2026-03-09 16-58-20" src="https://github.com/user-attachments/assets/8dffd198-c493-4802-afad-413ac9300c4b" />

Switch build platform from PC to Android
<img width="1393" height="806" alt="Screenshot from 2026-03-09 16-59-06" src="https://github.com/user-attachments/assets/6bccd371-866f-4f2d-8ba3-6fc1485a5ca1" />

Change build setting for Android
<img width="1393" height="806" alt="Screenshot from 2026-03-09 17-01-01" src="https://github.com/user-attachments/assets/f81b320b-f1d5-40e4-ba69-b976a6053a00" />

Make sure to import package "ros_workshop.unitypackage"
<img width="1393" height="806" alt="Screenshot from 2026-03-09 17-01-17" src="https://github.com/user-attachments/assets/26749a62-78db-46b1-8bd2-a32fe63a0fb2" />




If PC connected to the device that is set developper mode , it appers here
<img width="1734" height="914" alt="Screenshot from 2026-03-09 17-02-30" src="https://github.com/user-attachments/assets/3fe8ed92-f74e-4f14-bd74-5fbc850aa899" />



Build and run
and then you can recieve topic from Unity