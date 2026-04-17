# 🎫 Ticketing System API (.NET + MongoDB)

## 📌 Overview

This is a simple **Ticketing System API** built using **ASP.NET Core Web API** and **MongoDB**.
It allows users to create, manage, and track support tickets.

---

## 🚀 Tech Stack

* .NET 6 Web API
* MongoDB
* FluentValidation
* Serilog (Logging)
* Clean Architecture (Controller → Service → Repository)

---

## 📂 Project Structure

Controllers → Handle HTTP requests
Services → Business logic
Repositories → Data access (MongoDB)
Models → Entities
DTOs → Request/Response models
Middleware → Exception handling

---

## ⚙️ Features

* Create Ticket
* Get All Tickets (with filter + pagination)
* Get Ticket by ID
* Update Ticket (Status, Priority)
* Delete Ticket (Soft Delete)
* User association
* Validation using FluentValidation
* Logging using Serilog
* Global Exception Handling

---

## 📡 API Endpoints

| Method | URL              | Description                   |
| ------ | ---------------- | ----------------------------- |
| POST   | /api/Ticket      | Create Ticket                 |
| GET    | /api/Ticket      | Get All (Filter + Pagination) |
| GET    | /api/Ticket/{id} | Get by ID                     |
| PUT    | /api/Ticket/{id} | Update                        |
| DELETE | /api/Ticket/{id} | Soft Delete                   |

---

## 🧪 Sample Request

### Create Ticket

```json
{
  "title": "Bug Issue",
  "description": "Login not working",
  "priority": "High",
  "createdByUserId": "user1"
}
```

---

## 📊 Pagination Example

```bash
GET /api/Ticket?page=1&pageSize=5
```

---

## ⚠️ Validation Example

```json
{
  "errors": {
    "Title": ["Title is required"]
  }
}
```

---

## 🪵 Logging

Logs are stored in:

```
logs/log.txt
```

---

## ▶️ How to Run

```bash
dotnet restore
dotnet run
```

---

## 🔌 MongoDB Setup

* Install MongoDB
* Default connection:

```
mongodb://localhost:27017
```

---

## 💡 Interview Highlights

* Clean layered architecture
* Dependency Injection
* MongoDB integration
* Validation + Logging
* Pagination + Filtering
* Soft delete implementation

---

## 👨‍💻 Author

Darshan
