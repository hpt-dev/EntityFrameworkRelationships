# Entity Framework - 1 to 1, 1 to Many and Many to Many Relationships with .NET 6 in 2022

Source code used in this video: https://www.youtube.com/watch?v=9sXXfq0GDYI

In this video we'll use entity framework to set up 1 to 1, 1 to Many, and Many to Many relationships using a code first approach. The example project is an API for a blogging platform.

#dotnet #dotnetprogramming #dotnet6 #programming #csharp #programmingforbeginners #csharp #csharptutorial  #csharpdotnet #aspnetcore #programmingtutorials  #entityframework #entityframeworkcore #sqlserver #sql #sqlite #sqlforbeginners #database #sqldatabase #sqlservertutorial #codefirst #1to1 #onetoone #1tomany #onetomany #manytomany #codefirst 

▬ Contents of this video  ▬▬▬▬▬▬▬▬▬▬
0:00 - Introduction
0:24 - About the example project
0:40 - Creating the Blog entity
1:26 - 1 to 1 relationships
3:41 - Add migration, view changes in the database
4:16 - 1 to Many relationship
5:16 - Add migration, view changes in the database
5:30 - Many to Many relationship
6:20 - Add migration, view changes in the database

Start here if you've never used Entity Framework before:
https://www.youtube.com/watch?v=A4tpHy__LN0

Before Source Code:
https://github.com/hpt-dev/EntityFrameworkIntroduction

After Source Code:
https://github.com/hpt-dev/EntityFrameworkRelationships

Database Diagram:
https://ibb.co/RQnqXY1

What is a Navigation Property?
https://blog.staticvoid.co.nz/2012/entity_framework-navigation_property_basics_with_code_first/

https://www.c-sharpcorner.com/article/navigation-property-with-code-first-navigation-property-in-ef/

Microsoft Docs on Entity Framework
https://learn.microsoft.com/en-us/ef/

Useful Entity Framework Commands:
1. Add a Migration
add-migration migrationName -verbose

2. Apply migrations to database:
update-database

3. Remove the most recent migration:
remove-migration

4. Get SQL Script for a Migration (will write file to project folder):
script-migration -o ./fileName.sql 

5. Move database back to a previous migration:
update-database previousMigrationName
