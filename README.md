# MultiTier Contact List

A simple Windows Forms application for managing contacts, built with a multi-tier architecture.

## Features

- View all contacts in a data grid
- Add new contacts
- Update existing contacts
- Delete contacts
- Search contacts by ID

## Architecture

The application follows a three-tier architecture:

1. **Presentation Layer (UI)** - Windows Forms
2. **Business Logic Layer (BLL)** - Contact class
3. **Data Access Layer (DAL)** - ContactDB and DatabaseConnection classes

## Requirements

- .NET Framework 4.7.2
- SQL Server (local database)

## Setup

1. Clone the repository
2. Open the solution in Visual Studio
3. Build and run the application

## Usage

- Use the form fields to enter contact information
- Click the appropriate buttons to perform CRUD operations
- The data grid will automatically update to reflect changes