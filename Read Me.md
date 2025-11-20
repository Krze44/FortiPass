How to use the app -

Build using your compliler of choice, can use the one built into visual studio

Run the .exe file to launch the program

As a first time user set your Master Password, so you don't lose access to any accounts added / created

To add an existing account, click the "Add" button in the nav menu or click the "add" tab

Fill in a company name i.e Netflix, username, email associated if any, and your password

click the "Add Account" button and it will write your info to the Accounts.json file

click the "view" button, to view a table of all of your accounts

if anything breaks, i.e cant log in, go into config.ini and delete the text from masterpassword=, and leave a trailing whitespace, same with Salt=, set IsFirstTimeUser = true or IsFirstTimeUser = True
