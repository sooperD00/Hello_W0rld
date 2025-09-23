# Hello_W0rld
## a playful throwback written with modern tools; the start of a portfolio outside industry firewalls.

Welcome to **Hello_W0rld**, an interactive ASCII art console app written in **C#/.NET**.  

This project started as a simple “Hello World” program, and now it’s a **playful, command-driven ASCII REPL** where you can type anything and see it rendered in multiple Figgle fonts.  

It’s my first public GitHub project — a way to combine **professional coding practice** with a bit of **fun and nostalgia** from old-school terminals.  

---

## ✨ Features
- Prints `Hello_W0rld!` in ASCII art at startup  
- **Interactive REPL**: type text to render it  
- **Font commands**:
  - `list` → show all available fonts  
  - `set <font>` → select a specific font (Standard, Slant, Ghost, Banner, Doom)  
  - `random <text>` → print text using a random font  
- Press **Enter** on an empty line to quit  

# 🖥️ Example Session
*(TODO: add screenshots/gif here)*
```
Welcome to Hello_W0rld ASCII Console.
 _   _      _ _        __        __         _     _ 
| | | | ___| | | ___   \ \      / /__  _ __| | __| |
| |_| |/ _ \ | |/ _ \   \ \ /\ / / _ \| '__| |/ _` |
|  _  |  __/ | | (_) |   \ V  V / (_) | |  | | (_| |
|_| |_|\___|_|_|\___/     \_/\_/ \___/|_|  |_|\__,_|

Type something (or press Enter to quit).
Commands: list | set <font> | random <text>

> list
Available fonts:
 - standard
 - slant
 - ghost
 - banner
 - doom

> Mr. Lee
  __  __        _
 |  \/  |_ __  | |    ___  ___
 | |\/| | '__| | |   / _ \/ _ \
 | |  | | | _  | |__|  __/  __/
 |_|  |_|_|(_) |_____\___|\___|


> set slant
Font changed to: slant


> Uncle Enzo
   __  __           __        ______
  / / / /___  _____/ /__     / ____/___  ____  ____
 / / / / __ \/ ___/ / _ \   / __/ / __ \/_  / / __ \
/ /_/ / / / / /__/ /  __/  / /___/ / / / / /_/ /_/ /
\____/_/ /_/\___/_/\___/  /_____/_/ /_/ /___/\____/


> random Pizza Delivery!
______ _               ______     _ _                      _
| ___ (_)              |  _  \   | (_)                    | |
| |_/ /_ __________ _  | | | |___| |___   _____ _ __ _   _| |
|  __/| |_  /_  / _` | | | | / _ \ | \ \ / / _ \ '__| | | | |
| |   | |/ / / / (_| | | |/ /  __/ | |\ V /  __/ |  | |_| |_|
\_|   |_/___/___\__,_| |___/ \___|_|_| \_/ \___|_|   \__, (_)
                                                      __/ |
                                                     |___/
(above: doom font)
```


## ▶️ Installation & Usage (v1.1.0)

Now includes a **Windows installer**! 🎉

1. Go to the [Releases page](https://github.com/sooperD00/Hello_W0rld/releases) and download `Hello_W0rld_Installer.exe` for v1.1.0.
2. Run the installer and follow the prompts.
3. Launch Hello_W0rld from the Start Menu or desktop shortcut.
4. Type into the console and enjoy the ASCII render of your input.


## 📜 Why a Hello World Repo?

This repo is my personal first step in public GitHub coding after years of private work (semiconductors, manufacturing systems, and data). It's my way of saying:
- I can write clean, professional C# code
- I care about project structure, commits, and documentation
- I still enjoy the fun side of coding 🎮


## 🧰 Tech Stack
- Language: C#
- Framework: .NET 9 (compatible with .NET 6+)
- Library: [Figgle](https://www.nuget.org/packages/Figgle/) for ASCII fonts


## 📄 License
MIT License — free to use, share, and modify.
