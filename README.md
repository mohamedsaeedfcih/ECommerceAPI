# ECommerceAPI

## Description

ECommerceAPI is a simple e-commerce Web API built using ASP.NET Core. It includes essential features such as product management, user registration and login, and order processing.

## Features

- **Product Management**: Add, update, delete, and view products.
- **User Management**: Register, login, and view user details.
- **Order Management**: Create and view orders and order items.

## Technologies Used

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger for API documentation

## Getting Started

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/mohamedsaeedfcih/TaxCalculatorAPI.git
    cd ECommerceAPI
    ```

2. Set up the database:
    ```sh
    dotnet ef database update
    ```

3. Run the application:
    ```sh
    dotnet run
    ```

### API Documentation

The API documentation is available via Swagger. Once the application is running, navigate to `https://localhost:5001/swagger` in your browser to view and interact with the API endpoints.

### Project Structure

```plaintext
ECommerceAPI
│   Program.cs
│   Startup.cs
├───Controllers
│       ProductsController.cs
│       UsersController.cs
│       OrdersController.cs
├───Models
│       Product.cs
│       User.cs
│       Order.cs
│       OrderItem.cs
│       LoginRequest.cs
│       RegisterRequest.cs
├───Services
│       IProductService.cs
│       IUserService.cs
│       IOrderService.cs
│       ProductService.cs
│       UserService.cs
│       OrderService.cs
├───Repositories
│       IProductRepository.cs
│       IUserRepository.cs
│       IOrderRepository.cs
│       ProductRepository.cs
│       UserRepository.cs
│       OrderRepository.cs
├───Data
│       ECommerceDbContext.cs
└───Middleware
        ExceptionHandlingMiddleware.cs
