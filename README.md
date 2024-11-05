<h1>CDN - Complete Developer Network API</h1>
<p>
  A RESTful API built in <strong>C#</strong> using <strong>.NET Core</strong> with <strong>PostgreSQL</strong> as the database, designed for managing a directory of freelance developers. This API supports operations to create, read, update, and delete (CRUD) user profiles.
</p>

<h2>Features</h2>
<ul>
  <li><strong>User Management</strong> via RESTful endpoints: <code>GET</code>, <code>POST</code>, <code>PUT</code>, and <code>DELETE</code>.</li>
  <li>Built using <strong>Entity Framework Core</strong> with PostgreSQL for database management.</li>

</ul>

<h2>Technologies Used</h2>
<ul>
  <li><strong>.NET Core 8</strong> for the framework</li>
  <li><strong>PostgreSQL</strong> as the relational database</li>
  <li><strong>Entity Framework Core</strong> as the ORM</li>
  <li><strong>Dependency Injection</strong> for service management</li>
</ul>

<h2>Getting Started</h2>
<h3>Prerequisites</h3>
<p>To run this project locally, ensure you have the following installed:</p>
<ul>
  <li><strong>.NET SDK 8.0+</strong></li>
  <li><strong>PostgreSQL</strong> server</li>
</ul>

<h3>Setup Instructions</h3>
<ol>
  <li><strong>Clone the repository</strong>:
    <pre><code>git clone https://github.com/ShahinAlKabirMitul/CDN.git
cd yourrepository</code></pre>
  </li>
  <li><strong>Database Configuration</strong>:
    <p>Create a PostgreSQL database.</p>
    <p>Update the connection string in <code>appsettings.json</code> to point to your PostgreSQL instance:</p>
    <pre><code>{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost:5432; User Id=postgres; Password=postgrespw; Database=CDNDB"
  }
}</code></pre>
  </li>
  <li><strong>Run Migrations</strong>:
    <p>Set up the database tables using Entity Framework Core.</p>
    <pre><code>dotnet ef database update</code></pre>
  </li>
  <li><strong>Run the Application</strong>:
    <pre><code>dotnet run</code></pre>
    <p>The API will be accessible at <code>http://localhost:5000/api/users</code>.</p>
  </li>
</ol>

<h2>API Endpoints</h2>
<p>Here are the main endpoints available in the API:</p>

<ul>
  <li><strong>Get All Users</strong>:
    <pre><code>GET /api/users</code></pre>
    <p>Retrieves a list of all registered users.</p>
  </li>
  <li><strong>Get User by ID</strong>:
    <pre><code>GET /api/users/{id}</code></pre>
    <p>Retrieves a specific user by their ID.</p>
  </li>
  <li><strong>Create a New User</strong>:
    <pre><code>POST /api/users</code></pre>
    <p><strong>Request Body</strong>:</p>
    <pre><code>{
  "username": "JohnDoe",
  "email": "john@example.com",
  "phoneNumber": "123-456-7890",
  "skillSets": "C#, SQL, .NET",
  "hobby": "Hiking"
}</code></pre>
  </li>
  <li><strong>Update User</strong>:
    <pre><code>PUT /api/users/{id}</code></pre>
    <p><strong>Request Body</strong>:</p>
    <pre><code>{
  "id": 1,
  "username": "UpdatedName",
  "email": "updated@example.com",
  "phoneNumber": "987-654-3210",
  "skillSets": "JavaScript, React",
  "hobby": "Photography"
}</code></pre>
  </li>
  <li><strong>Delete User</strong>:
    <pre><code>DELETE /api/users/{id}</code></pre>
    <p>Deletes a user by their ID.</p>
  </li>
</ul>

<h2>Project Structure</h2>
<ul>
  <li><strong>Controllers</strong>: Contains API controllers for handling HTTP requests.</li>
  <li><strong>Models</strong>: Defines the data models (e.g., <code>User</code>) for the application.</li>
  <li><strong>Data</strong>: Includes database context and repositories, along with the Unit of Work pattern for transaction management.</li>
</ul>



<h2>License</h2>
<p>This project is licensed under the MIT License.</p>
