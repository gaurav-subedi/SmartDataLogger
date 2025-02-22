# Smart Data Logger

## Overview
The **Smart Data Logger** is a simple Windows application developed in C# using WinForms. It allows users to log data with a timestamp into a CSV file and display the logged data in a listbox. The application provides a user-friendly interface to input and store data entries efficiently.

## Features
- Logs data with an automatic timestamp
- Saves log entries in a CSV file (`data_log.csv`)
- Displays recorded logs in a ListBox UI component
- User-friendly WinForms UI
- Ability to add new log entries via a text input field and button click

## Technologies Used
- **C# .NET** (Windows Forms Application)
- **File Handling (CSV Storage)**
- **Event-driven programming (Button Click Events)**

## Installation & Setup
### Step 1: Clone the Repository
```sh
git clone https://github.com/gaurav-subedi/smart-data-logger.git
cd smart-data-logger
```

### Step 2: Open in Visual Studio
1. Open `SmartDataLogger.sln` in **Visual Studio**.
2. Ensure the project builds successfully.

### Step 3: Run the Application
- Press `F5` in Visual Studio or manually run `SmartDataLogger.exe` after building.

## Usage
1. **Enter data** into the text input field.
2. **Click the "Log Data" button** to save the entry.
3. The log is **automatically stored** in `data_log.csv`.
4. The latest log entries appear in the ListBox.

