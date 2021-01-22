# _Pierres Tasty Treats_

#### _An app for Pierre to market some tasty treats. Created 01/15/2021_

#### By _**Garrett Dean Brown**_

## Description

A website for the venerable Pierre to help market some new treats. Has The ability for users to create accounts and see their own added treats.

## User Stories:

* The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.
* There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
* A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Treat Object Properties
* Id
* Name
--------

## Flavor Object Properties
* Id
* Name

## Setup/Installation Requirements

* Database setup instructions:
  * Ensure garrett_brown.sql was downloaded
  * Create an appsettings.json file
  * add localhost port, database name (garrett_brown) and your mysql password. 
  * navigate to PT directory.
  * Run dotnet ef database update.
  * Enjoy, Pierre!

* Cloning options:
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory. (In our case, PT!)
  * Run GitBASH in PT.
  * Navigate to the PT directory ("cd PT" The file tree should look something like this: "\yourfiles\PierresTreats.Solution\PT")
  * While in the PT folder, type "dotnet run" in GitBash to run the program and click "Localhost:5000" to open up a webpage.
  * Enjoy, Pierre!

* Download option
  * Download files from GitHub repository by click Code and download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Navigate to PT directory.
  * Type "dotnet ef database update" in GitBash to update mysql the program.
  * Type "dotnet run" in GitBash to run the program and click "Localhost:5000" to open up a webpage!
  * Enjoy, Pierre!

## Known Bugs

_No known bugs!_

## Support and contact details

_Feel free to email me with any questions, comments, or reports!: gman9mm@live.com_

## Technologies Used

* C#
* cshtml
* CSS
* MySQL
* Entity
* Identity
* Linq
* MVCTest
* MarkDown

### License

_Copyright (c) 2021 **_{Garrett Brown}_**
_Licensed under MIT_

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

