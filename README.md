# 🏀 Automated Basketball Object Detection and Tracking

<p align="center">
  <img src="https://img.shields.io/badge/Built%20With-Python-3776AB?style=for-the-badge&logo=python" alt="Python" />
  <img src="https://img.shields.io/badge/Framework-YOLOv8-blueviolet?style=for-the-badge&logo=openai" alt="YOLOv8" />
  <img src="https://img.shields.io/badge/Object%20Tracking-ByteTrack-ff69b4?style=for-the-badge" alt="ByteTrack" />
  <img src="https://img.shields.io/badge/Dimensionality%20Reduction-UMAP-yellowgreen?style=for-the-badge" alt="UMAP" />
  <img src="https://img.shields.io/badge/Clustering-KMeans-1abc9c?style=for-the-badge" alt="KMeans" />
  <img src="https://img.shields.io/badge/Field-Computer%20Vision-29b6f6?style=for-the-badge&logo=opencv" alt="Computer Vision" />
  <img src="https://img.shields.io/badge/Field-Sports%20Analytics-orange?style=for-the-badge" alt="Sports Analytics" />
  <img src="https://img.shields.io/badge/Status-Active-success?style=for-the-badge" alt="Active Project" />
  <img src="https://img.shields.io/badge/Made%20With-%E2%9D%A4-red?style=for-the-badge" alt="Made with Love" />
</p>


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


## 🧠 Discussion

- **Model Selection:** Fine-tuned YOLOv8 models increased strict IoU scores (mAP50-95).
- **Tracking Improvements:** Re-identification modules are suggested to improve handling of tracking ID discontinuities.
- **Team Classification:** UMAP + KMeans clustering proved highly effective with a 3-cluster configuration (Team 1, Team 2, Referees).

---

## ✅ Conclusion

Our system provides an **accurate, real-time** solution for basketball analytics, successfully addressing challenges such as fast player motion, occlusions, and gameplay event detection.

---

## 🔮 Future Work

- 🏀 **Court Keypoint Detection:** Map basketball courts into 2D planes for enhanced spatial awareness.
- 📈 **3D Modeling:** Reconstruct player and ball trajectories in real-time environments.
- 🤖 **Physics-based Trajectory Prediction:** Predict shot success based on ball motion and player behavior.

---

## 📚 References

1. [Frontiers in Neurorobotics](https://www.frontiersin.org/journals/neurorobotics/articles/10.3389/fnbot.2020.620378/full)
2. [Journal of Quantitative Analysis in Sports](https://www.degruyter.com/document/doi/10.1515/jqas-2020-0088/html)
3. [Alexandria Engineering Journal](https://www.sciencedirect.com/science/article/pii/S1110016824010706#b1)
4. [Adria Arbues Thesis](https://arbues6.github.io/assets/pdf/compressed_%20Thesis_AdriaArbues.pdf)
5. [Roboflow Supervision Library](https://github.com/roboflow/supervision)
6. [Hugging Face Siglip](https://huggingface.co/docs/transformers/en/model_doc/siglip)
7. [UMAP](https://github.com/lmcinnes/umap)
8. [Roboflow Sports](https://github.com/roboflow/sports)
9. [Roboflow Universe Basketball Dataset](https://universe.roboflow.com/ownprojects/basketball-w2xcw)
10. [Roboflow Football AI Notebook](https://colab.research.google.com/github/roboflow-ai/notebooks/blob/main/notebooks/football-ai.ipynb)

---

## 📬 Contact

- **Hetu Patel:** [hetu.patel@torontomu.ca](mailto:hetu.patel@torontomu.ca)
- **Eric Mergelas:** [eric.mergelas@torontomu.ca](mailto:eric.mergelas@torontomu.ca)
- **Kushal Bhattad:** [kushal.bhattad@torontomu.ca](mailto:kushal.bhattad@torontomu.ca)
- **Chris Grover:** [c1grover@torontomu.ca](mailto:c1grover@torontomu.ca)

---

> _"Transforming basketball analytics with AI, one frame at a time."_ 🚀🏀


