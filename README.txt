[ISO Formst]
Sriram Poovaragavan
1321 UTC

2024-05-16

Recreated the ASDP.NET MVC Core application
using ET 7, no authentication
 
 Run the progree, Confirmed the defalut browser:
 https://localhost:7161/

 modified the index.cshtml title to say "Hello World" and confirmed

 created a Textfile.txt for documentataion

 Ran the application again to confirm the changes,

 1339 UTC
 confirm part 1 of the tututorial is completed then started Part 2
 Part 2 - Add a controller

 1344 UTC
 Completed Part 2 - Add a controller
 Tested the two different controller methods and confirmed by running the app in the browser abd nod;
 the URL to confirm:
 https://localhost:7161/HelloWorld/Welcome/0847874?name=Sriram

 1345 UTC
 I examined the Model-View-Controller (MVC) architecture and acknowledged its advantages in
 improving app organization and ease of testing by dividing Models, Views, and Controllers. 
 In order to start the project, I began by creating a controller called HelloWorldController.cs 
 with two separate functions: Index() and Welcome(). By exploring the mechanics of URLs, I understood 
 the correlation between web addresses and controller functions. Moreover, comprehending MVC routing
 helped me navigate through the application, clarifying how requests are determined by the structure
 of the URL. 



 
1348 UTC
Start Part3 - Add a View

1420 UTC
Added a view by creating a new folder named "HelloWorld" within the Views folder. 
Within this folder, added a new item - Razor View (Empty) named Index.cshtml. 
Replaced the contents of Views/HelloWorld/Index.cshtml with the provided markup,
including the title and a simple message. Navigated to https://localhost:7161/HelloWorld to confirm the changes.


2024-05-23

1425 UTC
Made changes to the shared layout file (_Layout.cshtml), including updating the title and navigation links.
Saved the changes and confirmed the updates by navigating through different pages of the application.

1430 UTC
Reviewed the Views/_ViewStart.cshtml file to ensure it was set to use the shared layout (_Layout.cshtml).
Opened Views/HelloWorld/Index.cshtml and adjusted the title and heading to reflect the new content.
Verified the changes by navigating to https://localhost:7161/HelloWorld and observed the updated title and heading.

1432 UTC
Passed data from the controller to the view by modifying the Welcome method in HelloWorldController.cs 
to include dynamic data in the ViewData dictionary. Created a Welcome view template named Views/HelloWorld/Welcome.cshtml
and used a loop to display the dynamic data passed from the controller. Tested the functionality by browsing to 
https://localhost:{7161}/HelloWorld/Welcome?name=Rick&numtimes=4 and observed the rendered HTML response.

1455 UTC
Part 4 - Added a model

Created a new class named Movie.cs in the Models folder and updated it with properties for Id, Title, 
ReleaseDate, Genre, and Price. Ensured the properties were properly annotated for data validation.
 
1500 UTC
Installed the required NuGet packages for Entity Framework Core to manage database interactions.
Built the project to check for any compiler errors.

1505 UTC
Used scaffolding to generate Create, Read, Update, and Delete (CRUD) pages for the Movie model. 
Created a new MoviesController and associated Razor view files for the CRUD operations.

1510 UTC
Ran initial migration to create the database schema. Opened the Package Manager Console and 
executed the commands Add-Migration InitialCreate and Update-Database to generate and apply 
the initial migration, respectively. Verified that the database schema was created based on the Movie model.

1512 UTC
Reviewed the scaffolded files including Controllers/MoviesController.cs, Views/Movies/*.cshtml, 
and Data/MvcMovieContext.cs. 

1513 UTC
Tested the app
 
1515 UTC
Part 5 - Working with the database

Registered the MvcMovieContext in the Program.cs file to manage database connections and object mapping.

1517 UTC
Verified the connection string in appsettings.json for local development.

1518 UTC
Explored SQL Server Express LocalDB to understand its role and default behavior in the development environment.

1520 UTC
Opened SQL Server Object Explorer (SSOX) and examined the structure and data of the Movie table.

1521 UTC
Created a new class named SeedData in the Models folder to seed the database with initial movie data if no records are present.

1522 UTC
Updated Program.cs to incorporate the seed initializer, ensuring the database is seeded during application startup.

20240523185938_InitialCreate
 
 
 
 
 
2024-05-30

Part 6 of the tutorial focusing on controller methods and view

1300 UTC
Opened the Models/Movie.cs file to enhance the presentation of the
movie release date. Added data annotations to properly format the ReleaseDate
and Price properties

1310 UTC
Examined the Views/Movies/Index.cshtml file to understand how the Edit, Details, 
and Delete links are generated using the Anchor Tag Helper. Verified that the 
generated HTML links matched the expected format and confirmed that the URLs 
point to the correct controller actions

1315 UTC
Reviewed the MoviesController to understand the HTTP GET and POST Edit methods.
The GET method fetches a movie by ID and returns it to the view, while the POST
method updates the movie details.

1320 UTC
Examined the Views/Movies/Edit.cshtml file generated by scaffolding to understand
how the form is created and validated.
https://localhost:7161/Movies/Edit/4

1325 UTC
Ran the application, navigated to the /Movies URL, and tested the Edit functionality. 
Verified that the changes in Movie.cs were reflected in the UI, with the release
date formatted correctly and validation messages appearing as expected for invalid input.

1330 UTC
Documented the completion of Part 6 in the project documentation file
and saved all changes. Confirmed that all aspects of the movie editing functionality,
including data annotations, Tag Helpers, and form validation, are working correctly.

1332 UTC
Part 7, add search to an ASP.NET Core MVC app


1333 UTC
Opened the Controllers/MoviesController.cs file to add the search capability. Updated the Index method

1335 UTC
Tested the search functionality by navigating to /Movies/Index and appending a query string, such as
?searchString=Ghost, to verify that the filtered movies are displayed correctly. 
Confirmed that the generated URLs include the search query, for example,
https://localhost:7161/Movies/Index?searchString=Ghost

1340 UTC
Updated the Views/Movies/Index.cshtml file to include a search form

1345 UTC
Enhanced the Index method to support genre-based filtering. Added a new view model, 
MovieGenreViewModel, in the Models folder

1350 UTC
Updated the Views/Movies/Index.cshtml file to incorporate genre filtering

1355 UTYC
Tested the application by searching for movies by genre, title, and both. 
Navigated to URLs like https://localhost:7161/Movies?MovieGenre=Comedy&SearchString=2 to ensure the filters work as expected.

1400 UTC
Documented the completion of Part 7 in the project documentation file
and saved all changes. Confirmed that the search functionality by genre and title is 
working correctly. Prepared for the next part of the tutorial.

2024-06-04

Part 8 of the tutorial focusing on adding a new field to the ASP.NET Core MVC app.

1345 UTC 
Added a new field, Rating, to the Movie model in Models/Movie.cs:
public string? Rating { get; set; }
Updated the MoviesController.cs file to include the Rating property in the [Bind] attribute for both
the Create and Edit action methods

1346 UTC
Updated the Views/Movies/Index.cshtml file to display the Rating field in the movie list

1350 UTC
Updated the Views/Movies/Create.cshtml file to include a Rating field for creating new movies.

Modified the SeedData class to provide a value for the new Rating column when seeding data.

Discovered that the app wouldn't work until the database was updated to include the new field. 
Encountered a SqlException due to the missing Rating column in the database table.

1355 UTC
Used Entity Framework Code First Migrations to update the database schema. Executed the following
commands in the Package Manager Console
These commands created a migration file named "Rating" and updated the database schema to include the new Rating column.

Tested the app to ensure that movies could be created, edited, and displayed with the Rating field.



1400 UTC
Documented the completion of Part 8 in the project documentation file (Textfile.txt) and saved all changes. 
Confirmed that the new field addition and database migration were successful.

 Part 9 of the tutorial focusing on adding validation to the ASP.NET Core MVC app

 1400 UTC
Added validation rules to the Movie model class in Models/Movie.cs
These validation attributes enforce rules such as required fields, string length constraints, 
regular expression patterns, and value ranges

1405 UTC
Explained how validation attributes work:

Required and MinimumLength attributes enforce that a property must have a value.
RegularExpression attribute limits what characters can be input.
Range attribute constrains a value to within a specified range.
StringLength attribute sets the maximum and minimum length of a string property.
Explained that value types are inherently required and don't need the [Required] attribute.
Discussed the benefits of automatic validation enforcement by ASP.NET Core, ensuring robustness and data integrity.

1410 UTC
Explained how validation error UI is automatically generated without changing the controller or views.

Demonstrated validation error messages displayed both client-side (using JavaScript and jQuery) and server-side.
Emphasized that the validation logic and error messages are specified only in the Movie class, 
ensuring consistency and adhering to the DRY principle.

1415 UTC
Described how validation works in the Create action method:

The [HttpPost] version of the Create method checks ModelState.IsValid to determine if there are any validation errors.
If validation fails, the form is redisplayed with error messages.
If validation passes, the movie is saved to the database.
Explained that the form data isn't sent to the server until client-side validation passes.

1420 UTC
Examined the usage of DataType attributes to provide hints for formatting and rendering data, 
such as DataType.Date and DataType.Currency.

Discussed the benefits of using DataType attributes:

Enables HTML5 features like calendar control and locale-appropriate formatting.
Allows MVC to choose the right field template for rendering data.
Highlighted that neither the controller nor the view template needs to know about the 
validation rules or error messages, as they are specified in the model class.

1425 UTC
Shared additional information about combining validation attributes and using
DisplayFormat attribute for specifying date format.

Warned about the limitations of jQuery validation with certain attributes like Range and DateTime.

Reviewed the Movie class with combined validation attributes.

Prepared for the next part of the series, focusing on improving the automatically 
generated Details and Delete methods.

Part 10, examine the Details and Delete methods of an ASP.NET Core app

1430 UTC
Examined the Details method in the Movie controller (MoviesController.cs)
This method retrieves details of a movie by its id and returns a corresponding view. 
It handles cases where id is null or when the specified movie is not found.

1435 UT
Reviewed the Delete and DeleteConfirmed methods

1440 UTC
Documented the review of the Details, Delete, and DeleteConfirmed methods in the project 
documentation file.

20240523185938


2024-06-60
Created GITHUB Account
I created the github repository and push the code on to the github account.
I authenticated from the my github accoint to push the code.
















 

