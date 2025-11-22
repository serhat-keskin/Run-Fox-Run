# Run Fox Run 🦊

**Run Fox Run** is a vibrant and fast-paced 2D platformer built with Unity. Guide your agile fox through challenging levels, collect treasures, and avoid dangerous obstacles in this polished side-scrolling adventure.

![Hero Idle](Assets/dog/Idle%20(1).png)

---

## 🎮 Game Overview

In **Run Fox Run**, players control a nimble fox capable of impressive acrobatic feats. The goal is simple but challenging: navigate through treacherous terrain, gather valuable collectibles, and survive to reach the exit.

The game features tight controls, a responsive camera system, and a classic health mechanic that keeps the stakes high.

---

## ✨ Key Features

*   **Fluid Movement System:**
    *   **Smooth Running:** Calibrated physics for satisfying horizontal movement.
    *   **Double Jump:** Reach higher platforms and correct course mid-air.
    *   **Wall Sliding & Interaction:** (Visualized through slide animations).
*   **Dynamic Collectibles:**
    *   💎 **Gems:** Rare treasures to hunt for.
    *   🪙 **Coins:** Gather wealth as you speed through the levels.
*   **Health & Combat:**
    *   **Heart System:** Classic visual health display with Full, Half, and Empty heart states.
    *   **Damage Effects:** Visual feedback when taking damage.
    *   **Death & Respawn:** Integrated `GameManager` handling player state.
*   **PC Optimized:**
    *   Designed for precise Keyboard & Mouse input.
    *   **Pause System:** Toggle game state on the fly.

---

## 🖼️ Visual Showcase

### Action Packed Animations
The game utilizes a full suite of sprite-based animations to bring the character to life:

| **Running** | **Jumping** | **Hurt** |
|:---:|:---:|:---:|
| ![Run Animation](Assets/dog/Run%20(3).png) | ![Jump Animation](Assets/dog/Jump%20(3).png) | ![Hurt Animation](Assets/dog/Hurt%20(3).png) |

*(Assets shown: Run Frame 3, Jump Frame 3, Hurt Frame 3)*

### Environment & UI
*   **Custom UI:** Sleek "Run Fox Run" branded menu with a dark purple theme.
*   **Particle Effects:** Footsteps and impact dust add weight to every movement.

---

## 🛠️ Technical Details

*   **Engine:** Unity 2022.x (Universal Render Pipeline)
*   **Language:** C#
*   **Architecture:**
    *   **Singleton Pattern:** Used for `GameManager`, `UIManager`, and `HealthManager` for efficient global state management.
    *   **Component-Based:** Modular scripts for `PlayerController`, `Pickup`, and `ExitTrigger`.

---

## 🕹️ Controls

| Action | Input |
| :--- | :--- |
| **Move** | `A` / `D` or Arrow Keys |
| **Jump** | `Spacebar` |
| **Double Jump** | Press `Spacebar` in air |

---

> *Project developed by Serhat.*
