# 🏀 Automated Basketball Object Detection and Tracking

📄 **Project:** Final Year Capstone | Toronto Metropolitan University  
🧑‍💻 **Team:** Hetu Patel, Eric Mergelas, Kushal Bhattad, Chris Grover

---

## 📖 Abstract

This project presents a real-time system for **automated basketball analytics** using advanced object detection and tracking.  
We tackle challenges like fast player movements, occlusions, dynamic camera angles, and action recognition to enable **accurate player, ball, and rim detection**, **shooting action annotation**, and **team classification** in live game footage.

---

## 📚 Table of Contents

- [Introduction](#introduction)
- [System Overview](#system-overview)
- [Tech Stack](#tech-stack)
- [Key Components](#key-components)
- [Results](#results)
- [Discussion](#discussion)
- [Conclusion](#conclusion)
- [Future Work](#future-work)
- [References](#references)
- [Contact](#contact)

---

## 🏀 Introduction

Traditional basketball analysis struggles with real-time processing of fast player movements, occlusions, and complex backgrounds.  
We introduce an **AI-powered system** leveraging deep learning and dimensionality reduction to **detect**, **track**, and **analyze** basketball gameplay effectively.

---

## ⚙️ System Overview

| Module | Purpose |
|:-------|:--------|
| **Video Preprocessing** | Frame extraction with GPU-acceleration and stride sampling (Supervision, ONNX Runtime) |
| **Object Detection** | Custom-trained YOLOv8 model & Roboflow 3.0 Fast Model |
| **Tracking** | ByteTrack for player and ball multi-object tracking |
| **Team Classification** | Player embedding generation (Siglip Vision), UMAP + KMeans clustering |
| **Visualization** | Dynamic annotations for players, ball, rim, shooting actions |

---

## 🛠️ Tech Stack

| Technology | Purpose |
|:-----------|:--------|
| Python | Core programming language |
| YOLOv8 | Object Detection (Players, Ball, Rim) |
| Roboflow | Dataset preparation and pretrained model |
| Supervision Library | Frame extraction and video preprocessing |
| ONNX Runtime (CUDA) | Model acceleration |
| ByteTrack | Multi-object tracking |
| Siglip Vision Model | Player image embedding |
| UMAP + KMeans | Dimensionality reduction and team classification |
| Google Colab | GPU training environment |

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
- Player, ball, and rim detected.
- ByteTrack assigns consistent IDs across frames.
- Filtering and smoothing for ball trajectory.

### 🏷️ Team Classification
- Extracted player crops → Siglip Vision embeddings.
- Reduced embeddings to 3D via UMAP.
- Grouped into clusters (Team 1, Team 2, Referees) with KMeans.

### 🎨 Visualization
- Blue, yellow, and magenta circles mark teams and referees.
- Triangle annotation for ball; green ellipse for rim.
- Red bounding boxes highlight shooting actions.
- Unique ID labels under players for consistent tracking.

---

## 📈 Results

| Metric          | 10 Epochs | 15 Epochs |
|:----------------|:---------:|:---------:|
| **mAP50**       | 93.4%     | 94.2%     |
| **mAP50-95**    | 71.1%     | 73.7%     |
| **Precision**   | 85.7%     | 89.4%     |
| **Recall**      | 90.1%     | 91.0%     |

- 🔥 **Real-time inference speed:** ~9.6 ms per image
- 🏀 Improved detection for players, ball, and rim even with dynamic movement and occlusions.
- 🎯 Successful clustering for team classification; minor overlap between referees and bystanders deemed acceptable.

---

## 🧠 Discussion

- **Model Selection:** Fine-tuning YOLOv8 increased strict IoU detection (mAP50-95).
- **Tracking Improvements:** Suggested re-identification modules to address ID discontinuities.
- **Team Classification:** 3-cluster setup proved optimal for practical gameplay analytics.

---

## ✅ Conclusion

Our system provides an **accurate**, **real-time** solution for basketball analytics, successfully addressing player motion, occlusions, and classification challenges.

---

## 🔮 Future Work

- 🏀 **Court Keypoint Detection:** Map court into a 2D plane for enhanced spatial analysis.
- 📈 **3D Modeling:** Reconstruct player and ball trajectories in real-time.
- 🤖 **Physics-based Trajectory Prediction:** Predict shot success based on ball motion analysis.

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
