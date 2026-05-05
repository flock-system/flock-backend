# 🐑 Flock

> A simple platform designed to help churches manage members and care for people.

---

## 📖 About the Project

Flock is a SaaS platform built to help small and medium-sized churches organize their members and care for people more effectively.

Many churches still rely on notebooks or spreadsheets, which often leads to disorganized data and lack of proper follow-up.
Flock aims to simplify this process by providing a clean, modern and easy-to-use system.

---

## 🎯 Goal

Create a simple, useful and scalable product that:

* Replaces manual member management (paper/Excel)
* Helps leaders track and care for people
* Can evolve into a commercial SaaS product
* Serves as a real-world portfolio project

---

## 🚀 Current Scope (MVP)

The first version focuses on:

* Member registration
* Member listing
* Basic validation
* Simple data structure

> ⚠️ The MVP is intentionally small to validate real usage before expanding.

---

## 🧩 Future Features (Roadmap)

* Member status (active, inactive, visitor)
* Interaction history (follow-ups)
* Groups / cells management
* Reports and insights
* Authentication and multi-church support

---

## 🏗️ Architecture

The project follows a **layered architecture inspired by Clean Architecture**, focusing on separation of concerns and scalability.

### 📦 Layers

* **API** → Entry point (Controllers, HTTP)
* **Application** → Business use cases and services
* **Domain** → Core entities and rules
* **Infrastructure** → Database and external integrations

---

### 🔄 Flow

User → API → Application → Domain → Infrastructure → Database

---

## 🛠️ Tech Stack

* Backend: .NET (ASP.NET Core Web API)
* Database: PostgreSQL
* ORM: Entity Framework Core

---

## 📂 Project Structure

```bash
/src
 ├── Flock.Api
 ├── Flock.Application
 ├── Flock.Domain
 ├── Flock.Infrastructure
```

---

## 🔀 Git Workflow

* `main` → Production
* `develop` → Development
* `feature/*` → New features

Pull Requests are required to merge into `main`.

---

## 📋 Project Management

We use GitHub Issues and Projects to manage:

* User Stories (business features)
* Tasks (technical work)
* Sprint-based execution

---

## 🧪 Current Status

🚧 In development — MVP phase

---

## 🤝 Contributing

This project is currently developed by a small team as a learning and product-building initiative.

---

## 📌 Vision

Flock is not just about managing data.

It’s about helping churches care for people better.

---

## 📎 License

MIT (or define later)
