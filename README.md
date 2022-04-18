# Baseball API

## Project Overview

```
Your assignment is to build a .NET Framework API Web Application using n-tier architecture covering a topic of your group's choosing.

This API should include at least one custom table per member of your group with a minimum of three tables (excluding the given user table), at least one of the tables should implement Foreign Key relationship between said tables.

Initial setup should include working together as a team to work through the planning stage. This stage should include:

A layout of what the database tables should look like and how they should interact (You might consider using a tool like dbdiagram.io (Links to an external site.))
You will need to review your idea and whiteboard this out with an instructor
Fill out the planning document attached to the project module.

Break out the work load into consumable chunks, from your immediate TODOs to your long term stretch goals
Delegating a table to each team member who will be responsible for full CRUD in that table.

```
## Application Goal

```
We wanted to create a database that can store baseball information. This application could be used for any baseball data.  We have made an example using MLB team information, however this API could be used to store baseball data from MLB to little league. 

You can add new information and also delete existing information from the database.  We currently use Swagger for our database testing.  

We use cascade delete in our service layer, meaning deleting a team will delete the players and games associated with that specific team.  

If you are familiar with standard API's, this will be very easy to navigate.  We have created this application with the intent of user usability, so it will be easy to traverse.

```
