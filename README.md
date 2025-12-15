# 📝 ToDo API

A lightweight .NET Web API for managing tasks. This project uses an **In-Memory Database**, so no SQL setup is required!

## 🚀 Features
* **CRUD Operations:** Create, Read, Update, and Delete tasks.
* **Smart Filtering:** Filter tasks by status (`?isComplete=true`).
* **Validation:** Automatically ensures Priority is between 1-3.
* **Swagger UI:** Visual testing interface included.

## 🛠️ Tech Stack
* C# & .NET 8
* Entity Framework Core (In-Memory)
* Swashbuckle (Swagger)

## 🏃 How to Run
1. **Clone** or download this repository.
2. Open the project in **Visual Studio**.
3. Press **F5** (Run).
4. The browser will open the **Swagger UI** automatically (usually at `https://localhost:xxxx/swagger`).

## 🔌 API Endpoints

| Method | URL | Description |
| :--- | :--- | :--- |
| **GET** | `/api/items` | Get all tasks. Optional: `?isComplete=true/false` |
| **GET** | `/api/items/{id}` | Get a single task by ID |
| **POST** | `/api/items` | Create a new task |
| **PUT** | `/api/items/{id}` | Update an existing task |
| **DELETE** | `/api/items/{id}` | Remove a task |

## 📦 Example JSON (POST)

```json
{
  "title": "Walk the dog",
  "isComplete": false,
  "priority": 2
}
