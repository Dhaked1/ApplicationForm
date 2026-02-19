# 📄 ApplicationFormApp

A web-based Application Form system built using **ASP.NET Core MVC** that allows users to submit personal, educational, and address details through a structured form interface.

---

## 🚀 Live Demo

👉 https://applicationform-7smy.onrender.com/

---

## 📌 Features

* User-friendly Application Form UI
* Personal Details Submission (Name, Phone, Email, DOB, Gender)
* Qualification Information (Degree, Branch, Percentage)
* Address Selection (Country → State → City → Pincode)
* Form Validation and Data Handling
* MVC Architecture (Separation of Concerns)
* Database Integration using Entity Framework Migrations
* Docker Support for Deployment

---

## 🏗️ Tech Stack

| Technology            | Usage                    |
| --------------------- | ------------------------ |
| ASP.NET Core MVC      | Backend Framework        |
| C#                    | Server-side Logic        |
| Entity Framework Core | ORM & Database Handling  |
| HTML / CSS            | Frontend UI              |
| SQL Server            | Data Storage             |
| Docker                | Containerized Deployment |
| Render                | Cloud Hosting            |

---

## 📂 Project Structure

ApplicationFormApp
│
├── Controllers → Handles user requests
├── Models → Data structure & validation
├── Views → UI Pages (Razor Views)
├── Migrations → Database schema changes
├── wwwroot → Static files (CSS, JS)
├── Program.cs → Application entry point
├── appsettings.json → Configuration
└── Dockerfile → Deployment configuration

---

## ⚙️ How to Run Locally

### 1️⃣ Clone Repository

```bash
git clone https://github.com/Dhaked1/ApplicationForm.git
cd ApplicationForm
```

### 2️⃣ Configure Database

Update connection string inside:

```
appsettings.json
```

### 3️⃣ Apply Migrations

```bash
dotnet ef database update
```

### 4️⃣ Run Application

```bash
dotnet run
```

Open browser:

```
https://localhost:5001
```

---

## 🐳 Run Using Docker (Optional)

```bash
docker build -t applicationform .
docker run -p 8080:80 applicationform
```

---

## 📊 Future Improvements

* Authentication System (Login/Register)
* Admin Dashboard
* File Upload Support
* API Integration
* Form Editing & Tracking
* Better UI with Bootstrap/React

---

## 👨‍💻 Author

**Dhaked**
GitHub: https://github.com/Dhaked1

---

## 📜 License

This project is for learning and educational purposes.
