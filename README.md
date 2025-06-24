Hotel Management System – Silver Oaks Hotel
About

The Silver Oaks Hotel Management System is a comprehensive desktop application developed using C# and SQL Server, designed to streamline hotel operations. It enables administrators and receptionists to efficiently manage clients, employees, rooms, bookings, packages, payments, and reports within a secure and user-friendly environment.

This system was developed as part of a group project by four contributors from North-West University, aiming to implement a fully functional, role-based management system for hotel operations.
Features
Functional Requirements

    Access Control: Secure login system with role-based access (Administrator and Receptionist)

    Client Management: CRUD operations for client records

    Employee Management: CRUD operations for employee records

    Room and Room Size Management: Update and view room and room size data

    Package Management: CRUD operations for packages

    Booking Management: Create, update, view, and delete bookings

    Check-in/Check-out: Track client stays

    Payments: Confirm payment status for bookings

    Reporting:

        Bookings per time period

        Most popular packages per time period

    Data Export: Export reports to CSV files

Non-Functional Requirements

    Help functionality for end-users

    Secure, unique usernames and passwords for each system user

    Database capacity to handle up to 5000 records (with annual export encouraged)

    Query performance optimized for <3s response time

    Separate access levels:

        Administrators: Full access to all features

        Receptionists: Restricted access (limited to bookings, check-ins/outs, payments, and client creation)

Technologies Used

    Frontend & Logic: C# (.NET Windows Forms)

    Backend: SQL Server

    Architecture: Layered project structure with a DataAccess class containing reusable CRUD methods

    Version Control: Git & GitHub

Installation & Usage

    Clone the repository.

    Open the solution in Visual Studio.

    Ensure SQL Server is running and the database schema is restored or created using the provided SQL scripts.

    Build and run the application.

    Log in using sample credentials (or register via the database).

Refer to the included User Manual for detailed guidance.
Documentation

Included in the repository:

    Project Scope

    Use-Case and Class Diagrams

    Logical & Physical Data and Process Models

    SQL Scripts for Table Creation and Data Manipulation

    Screenshots of UI and Generated Reports

    User Manual

    Team Activity Log with Time Breakdown

    GitHub Version Control Report

Authors

This system was developed by Group 03:

    Hein du Plessis

    Lohard Janse van Rensburg

    Salim Sofinia

    Coenri van Rooyen

Let me know if you'd like it tailored more for a portfolio presentation, academic submission, or deployment instructions.
