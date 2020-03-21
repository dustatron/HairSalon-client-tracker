# _Hair Salon Client Tracker_

#### _A web app that will keep track of Stylists and Clients_, _Mar. 20, 2020_

#### By _**Dusty McCord**_

## Description

This projects allows a Salon owner to keep track of their stylists and which clients those stylists have.

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
| When user opens application they have a choice to see all Clients or see all Stylists | Home | "See All Clients", "See All Stylists."|
| When a user clicks "See All Stylists", they are provided with a list of all Stylists | Click: "See All Stylists" | "Stylists:" "Stylist1", "Stylist2" OR "Add New Stylist"|
| When a user clicks on "Add A New Stylist", they are directed to a form to add a new Stylist | Cick: "Add A New Stylist | "Add A New Stylist" Name: "Input Name" |
| When a User Adds a new Stylist Name they are directed back to the Stylists Index page | Name: "Rose Nylund" Submit: "Add New Stylist" | Stylists: "Rose Nylund" |
| When a user clicks on a Stylist name, they are directed to a list of Clients of that Stylist | Click: "Rose Lylund" | Stylist Details: "List of Clients:" |
| From the Stylist Details Page, when a user click on "Edit Stylist", they are directed to a Edit Page Form | Click: "Edit Stylist" | Edit: "Rose Nylund" |
| When a user clicks on "Delete Stylist," they are directed to a confirmation page | Click: "Delete Stylist" | "Are you sure you want to delete this?" |
| When the user clicks on the name of a client. They are directed to the detail page for that client | Click: "client Name" | "client Name Deatails: |
| From the client Details Page, when the user clicks "Edit client Details", they are directed to an Clients/Edit Page | Click: "Edit client Details" | Edit "client Name" with Edit Form |
| After the User Submits the edit form, they are directed back to the client Details page | Click: "Save Changes" | client Index | 
| From the client Details Page, when the user clicks on Delete this client, they are directed to a confirmation page | Click: "Delete This client" | "Are you sure you want delete 'client Name' |
| From the client Details page, when the user clicks on the "Add A Review Button," they are directed to a review form for that particular client | Click: "Add A Review" | Add a new review for "client Name" | 
| After the User Fills out the review and submits, they are directed back to the the client details page and can see their review | Submit: " "Add Review" | "'client Name' Details" |
| When a user clicks "Read Review", they are directed to a page displaying specific details from that Review | Click: "Read Review" | Review Detail Page |
| From the Home Page, when User Clicks "See all Clients" they are directed to an index of all Clients with a description | Click: "See All Clients" | "client Index:"| 
| From the client Index Page, when the user clicks "Add New client", they are directed to an Add new client Create Page Form | Click: "Add New client" | Add A New client Form |
| After the user Adds a New client, they are directed back to the client Index, where the new client can be seen| Submit: "Add client" | client Index |
| When the user enters a term into the search bar, they are returned with a list of Clients whose names or keywords match the search | Search: "Sue" | Your Search Results: |


## Setup/Installation Requirements
_Make sure you have these tools installed on your computer:_
*  [Git version control](https://git-scm.com/downloads)
*  [MySql](https://azure.microsoft.com/en-us/free/mysql/)
*  [Microsoft .Net Core 2.2](https://docs.microsoft.com/en-us/dotnet/framework/install/)
*  [.Net Script](https://dotnet.microsoft.com/download/dotnet-core/2.2)


_In Terminal:_


* Using your terminal navigate to where you want to save this project by typing:
```sh
cd desktop
```

* Clone the file from GitHub by typing:
```sh
git clone  https://github.com/dustatron/HairSalon-client-tracker.git
```

* Navigate to the project folder by typing:
```sh
cd HairSalon-client-tracker/HairSalon
```
* Restore the project with this terminal command:
```sh
dotnet restore
```

* Open up MySql in your terminal with this command:
```sh
mysql -uroot -p{your password}
```

* Create a new table by typing:
```sh
CREATE DATABASE dusty_mccord;
```

* Open your new database by typing:
```sh
USE dusty_mccord;
```

* Create Stylists table by typing:
```sh
CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `StylistName` varchar(255) DEFAULT NULL,
  `Specialty` varchar(45) DEFAULT 'Hair',
  `Rate` int(11) DEFAULT '0',
  PRIMARY KEY (`StylistId`)
);

```

* Create Clients table by typing:
```sh
CREATE TABLE `clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `StylistId` int(11) DEFAULT '0',
  `Name` varchar(255) DEFAULT NULL,
  `Note` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`ClientId`)
);

```
* Now exit MySql by typing:
```sh
exit;
```

* Then start the webserver by typing:
```sh
dotnet run
```

* Open your web browser and navigate to localhost:5000
```sh
http://localhost:5000/
```

* If your setup worked you should see a welcome page with a rainbow background. 

**Note: To exit, simply press**
```sh
Ctrl + C
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

This tool is provided as is. 

## Technologies Used
* [_Git_](https://git-scm.com/downloads)
* [_C#_](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [_.NET Core 2.2_](https://docs.microsoft.com/en-us/dotnet/framework/install/)
* [_dotnet script_](https://github.com/filipw/dotnet-script)
* [_Asp.Net Core 2.2 MVC_](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio)
* [_Visual Studio Code_](https://code.visualstudio.com/)
* [MySQL 8.0.15](https://downloads.mysql.com/archives/community/)
* [MySQL Workbench 8.0.15](https://downloads.mysql.com/archives/workbench/)
* [Entity Core framework](https://docs.microsoft.com/en-us/ef/)
* [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Dusty McCord_**