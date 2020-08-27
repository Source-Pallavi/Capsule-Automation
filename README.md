## Table of contents
* [General info](#general-info)
* [Technologies](#technologies)
* [Setup](#setup)

## General info
This project is automating www.https://capsulecrm.com which is a crm tool.
	
## Technologies
Project is created with:
* C# version: 8.0
### Frameworks
* NUnit 
* Selenium
* Data Driven
### Design Pattern
* Page Object Model
### Packages
* DotNetSeleniumExtras.PageObjects- For Page object Model
* ExtentReports- To generate Test Reports
* NUnit- To define test cases, assertion
* NUnit3Adapter- Running test cases in Visual Studio
* Selenium.WebDriver- .Net Binding for selenium webdriver API
* Selenium.WebDriver.ChromeDriver- Driver for Google Chrome
* Selenium.Firefox.WebDriver-Driver for Firefox browser
* DNSClient- In this project it is uesd to get Host name
* Log4Net-Logging Test steps to log file
* ExcelDataReader.DataSet-Extension for reading microsoft excel files
* Newtonsoft.Json-To access data from json file
* Microsoft.Office.Interop.Excel- Assembly necessary for to do Microsoft office interop
	
## Setup
To run this project, install it locally using visual studio:
create a ms. project
downloaded the dependencies (the packages menthioned above)

## Scenarios
### First- Positive scenario of buying book

* Login to casulecrm application
* Navigates to Home page
* Login with correct credentials
* click on person icon and add a person
* click on cases icon
* click on Add Case button
* Create a new case with the added person
* Verify the correct case got created for the same person
* Verify the case status : Open
* Close the browser
* Navigates to homepage
* Log out from application

## Second- Negative test

* Try to Login with wrong username
* Try to Login with empty username
* Try to Login with wrong passowrd
* Try to Login with empty password
# Author 
 ## *Pallavi Dubey
