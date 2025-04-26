# 🏀 Automated Basketball Object Detection and Tracking

📄 **Project:** Final Year Capstone | Toronto Metropolitan University  

---

## 📖 Abstract

This project presents a real-time system for **automated basketball analytics** using advanced object detection and tracking.  
We tackle challenges like fast player movements, occlusions, dynamic camera angles, and action recognition to enable **accurate player, ball, and rim detection**, **shooting action annotation**, and **team classification** in live game footage.

---

## 📚 Table of Contents

- [Introduction](#-introduction)
- [System Overview](#-system-overview)
- [Tech Stack](#-tech-stack)
- [Key Components](#-key-components)
- [Results](#-results)
- [Demo Video](#-demo-video)
- [Discussion](#-discussion)
- [Conclusion](#-conclusion)
- [Future Work](#-future-work)
- [References](#-references)
- [Contact](#-contact)

---

## 🏀 Introduction

Traditional basketball analysis struggles with real-time processing of fast player movements, occlusions, and complex backgrounds.  
We introduce an **AI-powered system** leveraging deep learning and dimensionality reduction to **detect**, **track**, and **analyze** basketball gameplay effectively.

---

## ⚙️ System Overview

| Module                 | Purpose                                                      |
|:------------------------|:--------------------------------------------------------------|
| **Video Preprocessing** | Frame extraction with GPU-acceleration and stride sampling (Supervision, ONNX Runtime) |
| **Object Detection**    | Custom-trained YOLOv8 model & Roboflow 3.0 Fast Model          |
| **Tracking**            | ByteTrack for player and ball multi-object tracking            |
| **Team Classification** | Player embedding generation (Siglip Vision), UMAP + KMeans clustering |
| **Visualization**       | Dynamic annotations for players, ball, rim, shooting actions  |

---

## 🛠️ Tech Stack

| Technology            | Purpose                         |
|:----------------------|:--------------------------------|
| Python                 | Core programming language       |
| YOLOv8                 | Object Detection (Players, Ball, Rim) |
| Roboflow               | Dataset preparation and model   |
| Supervision Library    | Frame extraction and video preprocessing |
| ONNX Runtime (CUDA)    | Model acceleration              |
| ByteTrack              | Multi-object tracking           |
| Siglip Vision Model    | Player image embedding          |
| UMAP + KMeans          | Dimensionality reduction and clustering |
| Google Colab           | GPU training environment        |

---

## 🚀 Key Components

### 📹 Video Preprocessing
- Frame generator (`sv.get_video_frames_generator`) for low-memory streaming.
- Metadata extraction: frame rate, resolution, total frames.
- Stride sampling to reduce redundancy.

### 🎯 Model Training
- **Dataset:** 4,061 annotated basketball images from Roboflow.
- **First Setup (10 Epochs):** mAP50 93.4%, Precision 85.7%, Recall 90.1%.
- **Second Setup (15 Epochs):** mAP50 94.2%, Precision 89.4%, mAP50-95 improved to 73.7%.

### 🧩 Object Detection and Tracking
- Player, ball, and rim detection using YOLOv8.
- ByteTrack assigns consistent IDs across frames.
- Ball trajectory smoothing and tracking.

### 🏷️ Team Classification
- Extracted player crops → Siglip Vision embeddings.
- Reduced embeddings to 3D via UMAP.
- Clustered using KMeans (Team 1, Team 2, Referees).

### 🎨 Visualization
- Blue, yellow, and magenta circles mark team players and referees.
- Triangle for ball, green ellipse for rim.
- Red bounding boxes for shooting action.

---

## 📈 Results

| Metric          | 10 Epochs | 15 Epochs |
|:----------------|:---------:|:---------:|
| **mAP50**       | 93.4%     | 94.2%     |
| **mAP50-95**    | 71.1%     | 73.7%     |
| **Precision**   | 85.7%     | 89.4%     |
| **Recall**      | 90.1%     | 91.0%     |

- 🔥 **Real-time inference speed:** ~9.6 ms per image.
- 🏀 Improved detection even during dynamic player movements.
- 🎯 Robust clustering performance with minor referee overlap.

---

## 🎥 Demo Video

> 📢 _Watch our system in action!_

```html
<video width="800" controls>
  <source src="30sec-vid_result.mp4" type="video/mp4">
  Your browser does not support the video tag.
</video>
