#CDN - Complete Developer Network API
A RESTful API built in C# using .NET Core with PostgreSQL as the database, designed for managing a directory of freelance developers. This API supports operations to create, read, update, and delete (CRUD) user profiles.
#Features
User management via RESTful endpoints: GET, POST, PUT, and DELETE.
Built using Entity Framework Core with PostgreSQL as the database.
#Technologies Used
.NET Core 6
PostgreSQL (as the relational database)
Entity Framework Core (ORM)
Dependency Injection
#API Endpoints
Here are the main endpoints available in the API:

GET /api/users: Retrieve all users
GET /api/users/{id}: Retrieve a specific user by ID
POST /api/users: Create a new user
PUT /api/users/{id}: Update an existing user
DELETE /api/users/{id}: Delete a user
