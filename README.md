# Peart Agro Chemical Management System

A comprehensive Windows Forms application for managing agricultural chemical inventory, stock tracking, and pesticide management for agricultural operations.

## 📋 Features

- **User Authentication** - Secure login system with user session management
- **Dashboard** - Overview of key metrics and system status
- **Pesticide Management** - Add, edit, and manage pesticide inventory
- **Stock Tracking**
  - Stock In - Record incoming chemical supplies
  - Stock Out - Track chemical usage and distribution
  - Real-time inventory updates
- **Supplier Management** - Manage supplier information and records
- **Reporting** - Generate reports on chemical usage and inventory
- **Data Persistence** - MySQL database backend for reliable data storage

## 🛠️ Technology Stack

- **Language**: C# (.NET Framework)
- **UI Framework**: Windows Forms
- **Database**: MySQL
- **Architecture**: 3-tier (DAL, BLL, Forms)

## 📁 Project Structure

```
peartagrochecmicalsmanagementsystem/
├── Forms/                 # UI Forms (Dashboard, Login, Pesticide, etc.)
├── BLL/                   # Business Logic Layer
├── DAL/                   # Data Access Layer
├── Models/                # Data Models
├── Helpers/               # Utility Classes
├── Properties/            # Application Resources
├── App.config             # Configuration File
├── packages.config        # NuGet Dependencies
└── Program.cs             # Entry Point
```

## 🚀 Getting Started

### Prerequisites

- Windows OS (for Windows Forms)
- .NET Framework (version specified in project file)
- MySQL Server installed and running
- Visual Studio 2019 or later (recommended)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/peart-agro-chemical-management.git
   cd peartagrochecmicalsmanagementsystem
   ```

2. **Restore NuGet packages**
   - Open the project in Visual Studio
   - Right-click on the solution and select "Restore NuGet Packages"
   - Or use Package Manager Console:
     ```
     Update-Package -Reinstall
     ```

3. **Configure Database Connection**
   - Open `App.config`
   - Update the MySQL connection string:
     ```xml
     <connectionString name="DefaultConnection" 
         connectionString="Server=localhost;Database=agro_chemicals;User Id=root;Password=your_password;" 
         providerName="MySql.Data.MySqlClient" />
     ```

4. **Setup Database**
   - Create a MySQL database named `agro_chemicals`
   - Execute any provided SQL scripts (if available) to create tables
   - Ensure the database connection is working

5. **Build and Run**
   - Build the solution (Ctrl+Shift+B)
   - Run the application (F5 or Ctrl+F5)
   - Login with your credentials

## 📝 Usage

### Main Workflow

1. **Login** - Authenticate with your username and password
2. **Dashboard** - View summary of current operations
3. **Manage Inventory**
   - Add pesticides and chemicals
   - Record stock incoming (purchases)
   - Record stock outgoing (usage/sales)
4. **Track Suppliers** - Maintain supplier information
5. **Generate Reports** - Create reports on inventory and usage

## 🔧 Configuration

Edit `App.config` to customize:
- Database connection string
- Application settings
- UI preferences

Example configuration:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <connectionStrings>
    <add name="DefaultConnection" 
         connectionString="Server=localhost;Database=agro_chemicals;User Id=root;Password=;" 
         providerName="MySql.Data.MySqlClient" />
  </connectionStrings>
</configuration>
```

## 📦 Dependencies

Main NuGet packages used:
- **MySql.Data** - MySQL database connectivity
- **BouncyCastle** - Cryptography support
- **System packages** - Core .NET utilities

See `packages.config` for a complete list.

## 🐛 Troubleshooting

### Database Connection Issues
- Verify MySQL server is running
- Check connection string in `App.config`
- Ensure credentials are correct
- Verify database exists and is accessible

### NuGet Package Errors
- Clean the solution (Build > Clean Solution)
- Delete the `packages` folder
- Restore packages again

### Build Errors
- Ensure .NET Framework version matches project requirements
- Check that all dependencies are restored
- Verify Visual Studio is up to date

## 📄 License

[Add your license here - e.g., MIT, Apache 2.0, etc.]

## 👥 Contributors

- [Your Name] - Developer

## 📧 Contact & Support

For issues, questions, or contributions, please [open an issue on GitHub](https://github.com/yourusername/peart-agro-chemical-management/issues).

## 🔐 Security Notes

- Change default database credentials
- Use strong passwords for user accounts
- Keep MySQL server updated
- Implement proper access controls for sensitive data

---

**Last Updated**: June 2026
