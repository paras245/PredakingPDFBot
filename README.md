# 🦇 Predaking PDF Bot - AI Chat & Custom Data

Welcome to the **Predaking PDF Bot**! This is an AI-powered chat application styled like the **Batcomputer** 🖥️. You can load it with your own PDF documents (like a resume), and the AI will answer questions based *only* on the information in those files.

---

## 🎯 What it does currently (Current Scope)
Right now, the app is pre-loaded with intelligence, just like Batman's terminal:
- **🗂️ Reads PDFs:** It automatically reads any PDF files placed in the `wwwroot/Data` folder.
- **🔍 Fast Search:** It creates a smart database (vector search) to find answers in your PDFs instantly.
- **📱 The Bat-Computer UI:** A cool, mobile-friendly dark theme with:
  - 🟡 Neon gold text and tactical dark panels.
  - ⚡ A blinking "WELCOME BATMAN!" startup screen.
  - � Audio buttons so the AI can read its answers out loud.

## 🚀 What's coming next! (Future Scope)
Batman is always upgrading his gear. Future updates will include:
- **📤 Upload from browser:** Upload your PDFs directly from the website without touching the backend folders!
- **⚡ Instant processing:** The AI will read and learn from new files the second you upload them.

---

## 🛠️ Tech Stack (The Utility Belt)
Here is what powers the Batcomputer:
- **💻 .NET 9.0 Razor Pages** (The main framework)
- **🤖 Microsoft.Extensions.AI** (To connect the smart AI features)
- **🧠 Azure OpenAI / GitHub Models** (`gpt-4o-mini` for chatting, `text-embedding-3-small` to understand the PDFs)
- **🗄️ SQLite Database** (To store the fast search info locally)
- **🎨 Custom Vanilla CSS** (For that glowing, glass-like hacker feel)

---

## ⚙️ How to run the project

### 1. Set up your AI Key 🔑
This project uses GitHub Models for its AI. You need a free GitHub personal access token (it doesn't need any special permissions).

Add your token to the project safely using **.NET User Secrets**:
1. Open your terminal in the project folder.
2. Run this command (replace `YOUR-TOKEN` with your real token):
   ```bash
   dotnet user-secrets set GitHubModels:Token YOUR-TOKEN
   ```

### 2. Add your PDFs 📄
Put any PDF files you want the AI to learn from into the `wwwroot/Data` folder. The app will read them when it starts.

### 3. Start the Batcomputer 🦇
Run the app using the .NET CLI:
```bash
dotnet run
```
Open the `localhost` link it gives you in your browser, and start chatting!

---

> *"It’s not who I am underneath, but what I do that defines me."* - The Batcomputer 🦇
