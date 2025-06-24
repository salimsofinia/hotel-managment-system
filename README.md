# Hotel Management System – Silver Oaks Hotel

## About

The Silver Oaks Hotel Management System is a desktop-based application developed using C# (Windows Forms) and SQL Server. It is designed to streamline hotel operations by enabling authorized users to manage bookings, clients, employees, rooms, packages, and generate relevant reports. The system enforces role-based access and supports two user roles: Administrators and Receptionists.

This application was developed by Group 03 as part of a software development project at North-West University.

## Features

### Functional Requirements

- **Access Control**: Role-based login system (Administrator and Receptionist)
- **Client Management**: Create, read, update, delete client data
- **Employee Management**: Create, read, update, delete employee data
- **Room Management**: Update and view room and room size details
- **Package Management**: Create, read, update, delete packages
- **Booking Management**: Create, update, delete, and view bookings
- **Check-In and Check-Out**: Process guest check-in and check-out activities
- **Payments**: Confirm and track payments
- **Reports**:
  - Bookings per Time Period
  - Most Popular Package per Time Period
- **Data Export**: Export report data to CSV files

### Non-Functional Requirements

- User help and guidance features
- Unique username and password required for all users
- System capable of storing up to 5000 records before CSV archiving
- All queries optimized to return results within 3 seconds
- Role-based access:
  - **Administrators**: Full access to all features
  - **Receptionists**: Limited to clients, bookings, payments, check-ins, and check-outs

## Technologies Used

- **Frontend**: C# (Windows Forms)
- **Backend**: SQL Server
- **Architecture**: Multi-tier with centralized `DataAccess.cs` for shared methods
- **Version Control**: Git and GitHub

## Installation & Setup

1. Clone the repository:
