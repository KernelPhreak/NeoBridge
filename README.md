# NeoBridge

NeoBridge is a Windows desktop application built with **C# WinForms** that automatically detects supported digital cameras and transfers newly captured photos to the PC in near real time.

The project focuses on **reliability, simplicity, and extensibility**, providing a lightweight alternative to vendor camera software.

---

## Features

- Automatic USB camera detection
- Device, drive, and folder selection
- Background photo transfer
- Optional delete-after-transfer
- Safe handling of Nikon MTP quirks
- Clean WinForms UI (no MVVM)
- Event-driven architecture

---

## How It Works

NeoBridge uses **Media Transfer Protocol (MTP)** to monitor selected camera folders and detect new files using polling.

When a new photo appears:
1. The file is downloaded to the PC
2. Optional deletion from the camera occurs
3. The app continues monitoring without interruption

---

## Supported Cameras

NeoBridge supports cameras that expose storage via **MTP**, including most models from:

- Nikon
- Canon
- Sony
- Fujifilm
- Panasonic

---

## Planned Features

Some advanced camera features require **PTP** and are planned for future versions:

- Live View (JPEG preview polling)
- Remote shutter control
- Camera setting control
- EXIF-based auto-sorting

PTP support will be implemented using **libgphoto2** or vendor SDKs.

---

## Tech Stack

- C# (.NET)
- WinForms
- MediaDevices (MTP)
- Event-driven design

---

## Project Goals

- Simple setup
- Reliable transfers
- Readable, maintainable code
- No unnecessary frameworks
- Clear upgrade path to full tethering
