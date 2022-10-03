# Laboratory-Database-Management-System

Introduction
Project Abstract:
The project aims to provide a systematic approach to creating a database system which involves the detection of mosquito-borne diseases by collecting patient biodata, panel information, medical history, etc. The aforementioned information is generated and collected through the creation of various forms.
This particular database is extremely potent in the sense that I deal with diseases that are rampant in our particular conditions and can help facilitate the provision of better understanding regarding patient care and diagnosis. The desktop application procured after the conception of the code is extremely beneficial especially for patients to easily enter their information as well as the specified organization dealing with the medical information. The latter could aid in keeping proper medical records and managing a proper and easily accessible setup.

Aims and Objectives:
The database aims to provide a straightforward and well-ordered approach towards the accumulation of patient information, personal as well as medical to facilitate finding whether they have acquired a mosquito-borne disease or not. It is extremely potent in the sense that diseases such as malaria and dengue are rampant considering the recent weather situation. 

Mechanism: 
Various software such as SQL Server and Visual Studio have been utilized throughout, the inception of this database. Visual Studio was connected to the SQL Server using the server’s name and the code was implemented using C#. The forms/entities were developed through various built-in tools and the tables were created on the Server using SQL queries. After the formulation of the overall database, a desktop application has been generated. The conception of the desktop app is possible due to coding done at the back end of the buttons and the data stored in the forms using an SQL server.
Tools and Languages Used:
Microsoft SQL Server: It is an RDBMS that Microsoft created for managing relationships between databases. Its main purpose is to store and retrieve data when other software applications need it.
Microsoft Visual Studio: It is a Microsoft integrated development environment (IDE). It is utilised to create computer programmes, websites, web applications, web services, and mobile applications.
Transact-SQL: It is a proprietary addition to SQL (Structured Query Language) developed by Microsoft for use with relational databases.
C#: It is a computer language made by Microsoft. It enables developers to build a variety of applications and can interact with databases.
SQL (Structured Query Language): It is a widely used language for interacting with databases. It may be used to make databases, and tables, enter data into them, update data, delete data, and more.


Breakdown of Project

 ![image](https://user-images.githubusercontent.com/114800119/193590564-f0f1e07c-a561-40f0-ab1a-e8fec030c442.png)
The Desktop Application Interface

Explanation and Illustration of Forms:
Log In: The first thing that appears on the user interface is the log-in form. The user will enter their information in the username and password textboxes on the form before clicking the "login" button, which will cause the selected SQL statement to be executed. After being entered, the user name and password are saved in the database. ‘Select Query’ is afterwards used to select and compare the entered credentials with the credentials that Visual Studio has already stored. The next form will be opened if the entered credential matches the valid values stored.  
![image](https://user-images.githubusercontent.com/114800119/193590606-1c7975d3-b4d2-4da7-8ebc-b2403a56e5c3.png)

 

Personal Information: 
This form is specified in including personal information i.e., Name, Age, Gender, Contact Number, Email Address and Postal Address, panel information detailing affiliation with any particular organization government-relate dated post and applicable codes related to the latter. Here the ‘ID’ column is used as a primary key which can be used to perform different data manipulation or selection commands. The form is useful for the user to fill in his/her personal information which will be later on referenced through the key attribute and shown on the Patient Certificate.
 ![image](https://user-images.githubusercontent.com/114800119/193590703-8c6fc5b4-793a-46d0-b432-c4276e23508f.png)


Medical History: The form helps store and retrieve information on the patient's symptoms, blood type, and medical history of illnesses like diabetes, hypertension, etc. The Personal Information Form using the ‘Select Command’ will display the relevant data when the Patient ID is entered. With the help of the ‘Submit’ button, all the information will be stored.
 ![image](https://user-images.githubusercontent.com/114800119/193590733-a846b737-e6bc-4019-8e14-412c8ba80204.png)


Symptoms: This form comprises two fields or text boxes, one of which is a description area where the user is required to describe their symptoms in detail and discuss their medical conditions, such as body temperature and blood pressure. The user only needs to indicate with a Yes or No whether or if someone else has also been affected in the other box, which is a dropbox.
![image](https://user-images.githubusercontent.com/114800119/193590776-df6b0179-6a02-4482-87bd-14420bf5c4a4.png)

 
Class: The form simply includes two columns or boxes: the first is for Class D, which stands for Dengue and the other is for Class M which is for Malaria. ComboBox has also been used for the classes as a combination of a Text Box and a ListBox control. Only one list item is displayed at a time in a ComboBox and other available items are loaded in a drop-down list. This section of code is implemented using an insertion command. To move further, the user must make the appropriate selection and click the submit button.
![image](https://user-images.githubusercontent.com/114800119/193590803-68b42c2f-77d5-4fd6-aa80-0c6a392c3331.png)

 

Certificate: This is the last form that the user will see. The form will immediately match the entered "ID" to the saved data, such as "Name" and "Address." This form intends to certify that the user has received the appropriate diagnosis and treatment for the ailment entered.
![image](https://user-images.githubusercontent.com/114800119/193590829-13f710a8-bec6-4416-9b57-b4241775bd6d.png)

 
Output: The filled-out certificate of the patient or user, which was made possible by this application, is displayed in the output.
![image](https://user-images.githubusercontent.com/114800119/193590850-12fc02ac-2f6d-4a17-888d-e3b1b00c4c87.png)

 
Future Suggestions: More functionality, such as confirming the accuracy of the data against the patient ID with a national database to see if it already exists or not, will be added to the desktop applications. To communicate and monitor the client's health more effectively, we intend to send them an email as well. Finally, to improve the functionality and usability of the desktop applications, we will introduce a feedback option.

Conclusion: Healthcare application development services are in demand since, in developed nations, the modern healthcare sector is practically excitable without digital technologies. Digital technology integration in this field takes place at many levels and aims to achieve various things. The initial programmes allowed for the reading and keeping of health indicators. Today's healthcare software development satisfies the requirements of the government, insurance companies, investors, and physicians. For such a broad industry, digital development products include desktop programmes, mobile applications, AND, AR/VR technologies, and whole software systems. By gathering patient biodata, panel information, medical history, etc., the project seeks to offer a systematic method to develop a database system that involves the diagnosis of diseases carried by mosquitoes. The production of various forms is used to generate and gather the aforementioned data. The fact that I deal with diseases that are prevalent in our specific situations makes this particular database very powerful and can aid in the facilitation of the provision of greater understanding regarding patient treatment and diagnosis. The desktop application acquired after the code was created is quite helpful, especially for patients to simply submit their information as well as the specific organisation dealing with the medical information. The latter could help manage a suitable and conveniently accessible setup and retain correct medical records.
