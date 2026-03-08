# ASP.NET Core Web API Clean Architecture Learning Project 🚀

Welcome! This repository documents my journey of learning **ASP.NET Core Web API using Clean Architecture**.
The project demonstrates how to build scalable backend applications by separating concerns into multiple layers.

The following technologies are used in this project:

* ASP.NET Core Web API (.NET 8)
* Entity Framework Core
* SQL Server
* Clean Architecture
* Dependency Injection
* Repository Pattern
* CQRS (MediatR)

---

## 🏗 Project Architecture

The solution follows **Clean Architecture** with the following layers:

### 📌 MyApp.API

* Entry point of the application
* Contains API Controllers
* Handles HTTP requests and responses
* Configures middleware and dependency injection

### 📌 MyApp.Application

* Contains application business logic
* DTOs and interfaces
* Command and Query handlers (CQRS)

### 📌 MyApp.Core

* Contains domain entities
* Business rules
* Domain interfaces

### 📌 MyApp.Infrastructure

* Database access implementation
* Entity Framework Core configuration
* Repository implementations
* External service integrations

---

## 📚 Learning Modules

### 👉 Lesson 1: Setup Clean Architecture

* Creating solution structure
* Creating API, Application, Core, and Infrastructure projects
* Adding project references

---

### 👉 Lesson 2: Implement CRUD Operations

The following CRUD operations are implemented:

* Get all records
* Get record by Id
* Create new record
* Update record
* Delete record

Technologies used:

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* CQRS using MediatR

---

### 👉 Lesson 3: Options Pattern

* Access configuration from **appsettings.json**
* Strongly typed configuration using **Options Pattern**
* Reduces key name errors in configuration access

---

### 👉 Lesson 4: Calling External APIs using HttpClient

* Using **HttpClient Typed Client**
* Calling external APIs from ASP.NET Core
* Following Clean Architecture principles

---

## 🛠 Technologies Used

* ASP.NET Core Web API (.NET 8)
* C#
* Entity Framework Core
* SQL Server
* MediatR
* Clean Architecture
* Git & GitHub

---

## 🎯 Purpose of This Repository

* Learn **Clean Architecture implementation**
* Practice **real-world backend development**
* Understand **scalable project structure**
* Track **daily learning progress**

---

⭐ This repository is part of my journey to become a **Full Stack .NET Developer**.
