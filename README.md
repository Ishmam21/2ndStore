# 2ndStore: A CRUD Operations Project using .NET Framework and MySQL

This project demonstrates CRUD (Create, Read, Update, Delete) operations using Windows Forms in C# with a MySQL database.

## Features

- **Create**: Add product details such as `Product ID`, `Brand`, `Model`, `StorageGB`, `Colour`, and `Date` to the database.
- **Read**: Display product information from the database using a `DataGridView`.
- **Update**: Modify existing product records in the database.
- **Delete**: Remove product records from the database.

## Architecture

This project is a simple CRUD application developed using C# .NET Framework. It uses a single table named `dbo.ProductINFO` in the `IndProj` database to manage product information.

### Database Schema

The `ProductINFO` table schema consists of the following fields:

- **ProductID** (int): The primary key that uniquely identifies each product.
- **Brand** (nvarchar(50)): The brand name of the product.
- **Model** (nvarchar(max)): The model description of the product.
- **StorageGB** (nvarchar(50)): The storage capacity of the product in gigabytes.
- **Colour** (nvarchar(50)): The color of the product.
- **Date** (datetime): The date the product was added.
- **UpdateDate** (datetime): The last update date of the product details.

Below is the schema diagram for the `ProductINFO` table:

![productinfo_schema](https://github.com/user-attachments/assets/524f9264-6b23-4ffa-aac2-aa7a5e50d77d)



This diagram provides a visual representation of the table structure and its fields, illustrating how the data is organized within the database.


## Prerequisites

- Visual Studio (with .NET Framework)
- SQL Server/MySQL
- Windows Forms App Template

## Setup

1. Clone this repository.
2. Open the solution in Visual Studio.
3. Set up your SQL Server (or MySQL equivalent).
4. Update the connection string in the code (`Form1.cs`) to match your local SQL Server setup. It currently uses SQL Express:

    ```csharp
    SqlConnection con = new SqlConnection("Data Source=LAPTOP-JMHFMUO7\\SQLEXPRESS01;Initial Catalog=IndProj;Integrated Security=True;...");
    ```

5. Build and run the project.

## Database Setup

This project interacts with a database table named `ProductINFO`. Ensure you create the table using the following script:

```sql
USE [IndProj]
GO
/****** Object:  Table [dbo].[ProductINFO]    Script Date: 9/11/2024 10:04:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductINFO](
    [ProductID] [int] NOT NULL,
      NULL,
    [Model] [nvarchar](max) NULL,
      NULL,
      NULL,
    [Date] [datetime] NULL,
    [UpdateDate] [datetime] NULL,
    CONSTRAINT [PK_ProductINFO] PRIMARY KEY CLUSTERED 
    (
        [ProductID] ASC
    ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, 
    IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, 
    ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) 
    ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
)
GO
```
## Screenshots

Main Interface: Shows the form with options to add, edit, delete, and display products.

![Screenshot 2024-09-11 09 48 37](https://github.com/user-attachments/assets/1dc9c2ea-ec94-4491-bafa-6267d3cb5888)

