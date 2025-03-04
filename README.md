# Task Management System

## Project Overview
### Purpose
The **Task Management System** is a Windows Forms (WinForms) application developed using **ASP.NET Core** with **Entity Framework Core**. It enables a single user to efficiently manage personal tasks while leveraging **LINQ queries** for optimized data handling.

## Core Functionalities
- Add, update, delete, and view tasks effortlessly.
- Filter and sort tasks based on different criteria.
- Track task progress with statuses: **Pending, In Progress, Completed**.
- Search tasks using keywords in the title or description.
- Generate insightful reports on task status and performance.

---

## Database Schema
The system comprises three primary entities:

- **User** – Represents individuals using the system.
- **TaskItem** – Contains task details such as title, description, due date, priority level, and status.
- **Category** – Organizes tasks into different categories.

### Entity Relationships
- **User → TaskItem (One-to-Many)** – A user can create multiple tasks, but each task belongs to one user.
- **Category → TaskItem (One-to-Many)** – A category can contain multiple tasks, but a task belongs to only one category.

---

## Features Breakdown
### Basic Features
- Perform full CRUD operations (Create, Read, Update, Delete).
- Filter tasks by status.
- Sort tasks by due date.

### Intermediate Features
- Search tasks by title/description.
- Group tasks by priority.
- Display unique priority levels.
- Paginate tasks for better user experience (e.g., 5 tasks per page).

### Advanced Features
- Track overdue tasks and send alerts.
- Generate reports for completed vs. pending tasks.
- Calculate average task completion time.
- Implement custom UI controls for better visualization.
- Provide advanced reporting capabilities.

---

## Installation & Setup
1. Clone the repository from **GitHub**.
2. Open the project in **Visual Studio**.
3. Ensure **.NET Core SDK** and **SQL Server** are installed and configured.
4. Run the necessary database migrations.
5. Build and launch the application.

---

## Usage
- Create new tasks with ease.
- Modify or delete existing tasks as needed.
- Filter, sort, and search tasks for efficient task management.
- Generate reports to analyze progress and completion status.

---

## Technologies Used
- **.NET Core** – Backend development framework.
- **Windows Forms (WinForms)** – User interface technology.
- **Entity Framework Core** – ORM for database interactions.
- **SQL Server** – Database management system.
- **LINQ Queries** – Data querying and manipulation.

---

## Contributing
Contributions are welcome! Fork the repository, enhance the features, and submit pull requests to improve the project.



---

Developed by Rahil

