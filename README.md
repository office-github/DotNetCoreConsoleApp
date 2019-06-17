# DotNetCoreConsoleApp
EF Core 2.2 in .NET Core 2.2

<details>         
<summary> Brief </summary>
<p>This console app fetches the record from the existing database 'Practice' and table 'Student'.
This is the example of the code first approach of the EF Core.

This console app contains below folders
1. Data
2. Models
3. Services
</p>
</details>

<details>
<summary> Details of each Folders</summary>
  ```
<p>
  <details>
<summary> 1. Data </summary>
    <p>
This folder contains the below two classes:

### a. DBContext.cs
Provides below things:

i. Connection strings

ii. Connection to the SQL Sever Database

iii. This class reads the Model(s) i.e. Student from the assemblies dynamically and creates the models in the database if not available.

### b. Repository.cs
Provides below things

i. This class is generic class for all the available entities i.e. Models (for eg. Student)

ii. This will provides the data access to the table i.e. Student
</P>
</details>

<details>
<summary> 2. Models</summary>
  <p>
This folder contains the blelow two classes:
    
### a. Student.cs
This is the model for the student entity to the database.

### b. StudentMap.cs
This class contains the configuration to map the Model 'Student' with the 'Student' table in the database.
</P>
</details>

<details>
<summary> 3. Services </summary>
  <p>
This folder contains the blelow one class:

### a. GenericService.cs
This class contains two methods:

i. ExecuteWithResult()
This establishes the connection with the database and captures the exception and logs to the exception to the console if it fails to connect to the database.
If Connection success, then it will returns the repository to the particular entity i.e. Student.

ii. GetList<T>()
Generic method to fetch record from the particular repository of the Model 'T'.
  </p>
  </details>
</p>
</details>
```
