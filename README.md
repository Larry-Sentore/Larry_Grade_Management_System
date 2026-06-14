# Grade Management System

A Windows Forms app for managing student grades

## Requirements

- .NET 10 SDK
- Windows (required for Windows Forms)

## How to Run

### Option 1: Visual Studio
1. Open `Grade_Management_system\Grade_Management_system.slnx` in Visual Studio.
2. Press **F5** to build and run.

### Option 2: Command Line
```bash
cd Grade_Management_system\Grade_Management_system
dotnet run
```

## Features

- **Add Student** — enter a name and grade (0–100) to register a student
- **Update Student** — change an existing student's grade
- **Search Student** — look up a student's current grade
- **View All Students** — display all students with their percentage and letter grade
- **Average Grade** — calculate the class average
- **Highest / Lowest Grade** — find the top and bottom scores

## Grade Scale

| Letter | Range |
|--------|-------|
| A      | 90–100% |
| B      | 80–89% |
| C      | 70–79% |
| D      | 60–69% |
| F      | 0–59% |
