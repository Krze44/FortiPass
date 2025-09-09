This is a program that is meant to allow the user to create randomly generated usernames, passwords, and email addresses, and store them for later use, locally but securely.


GetRandomNumber(maxNum):

	int randomNumber equals the result of a "true random" random number generator;
	return randomNumber % maxNum;

GeneratePassword(int length, bool useSpecialCharacters, bool useNumbers, bool useUpperCase):

	string allowedCharacters is initialized to all the lowercase letters of the alphabet;
	string returnString is initialized to an empty string;

	if useSpecialCharacters is true:
		we add "!@#$%^&*" to allowedCharacters string;

	if useNumbers is true:
		we add "0-9" to allowedCharacters string;

	if useUpperCase is true:
		we add all of the upper case variants of the alphabet to the string;

	for each number between 1 and "length":

		char letterToAdd equals allowedCharacters[at index GetRandomNumber(length of allowedCharacters)];

		if the count of letterToAdd in returnString is greater than or equal 3:
			string tempAllowedCharacters equals allowedCharacters;
			tempAllowedCharacters equals tempAllowedCharacters.Replace(letterToAdd with nothing);
			we add a character from the tempAllowedCharacters at index GetRandomNumber(length of allowedCharacters);

		else:
			we add letterToAdd to the returnString;

		return returnString

	
GenerateUserName(int length, bool useSpecialCharacters, bool useNumbers, bool useUpperCase):

	GeneratePassword(int length, bool useSpecialCharacters, bool useNumbers, bool useUpperCase);

GenerateEmail(int length, bool useSpecialCharacters, bool useNumbers, bool useUpperCase, string emailSuffix):

	string allowedCharacters is initialized to all the lowercaser letters of the alphabet;
	string returnString is initialized to an empty string;

	if useSpecialCharacters is true:
		we add "! # $ % & ' * + - / = ? ^ _ \ {" to the allowedCharacters string;

	if useNumbers is true:
		we add "0-9" to allowedCharacters string;

	if useUpperCase is true:
		we add all of the upper case variants of the alphabet to the string;

	for each number between 1 and "length":

		char letterToAdd equals allowedCharacters[at index GetRandomNumber(length of allowedCharacters)];

		if the count of letterToAdd in returnString is greater than or equal 3:
			string tempAllowedCharacters equals allowedCharacters;
			tempAllowedCharacters equals tempAllowedCharacters.Replace(letterToAdd with nothing);
			we add a character from the tempAllowedCharacters at index GetRandomNumber(length of allowedCharacters);

		else:
			we add letterToAdd to the returnString;
	
	add emailSuffix to returnString;

	return returnString

CreateAccount(bool createUsername, bool createPassword, bool createEmail)
	
	string userName is initialized to null;
	string Password is initialized to null;
	string Email is initialized to null;
	string Company is initialized to empty string;
	string Account is initialized to an empty dictionary;

	if the winform's username field has a length greater than 0:
		userName equals the username field's text
	else:
		userName equals the result of GenerateUsername(length, useSpecialCharacters, useNumbers, useUppercase)

	if the winform's password field has a length greater than 0:
		Password is equal to the password field's text
	else:
		Password equals the result of GeneratePassword(length, useSpecialCharacters, useNumbers, useUppercase)

	if the winform's email field has a length greater than 0:
		Email is equal to the email field's text
	else:
		Email equals the result of GenerateEmail(length, useSpecialCharacters, useNumbers, useUppercase, emailSuffix)

	Company equals the company field's text;

	if Email's value isn't null:
		add Email's value to account under the key "email";

	if userName's value isn't null: 
		add userName's value to account under the key "username";
	
	if Password's value isn't null:
		encryptedPassword equals the result of encrypting the plain text with bouncycastle's encryption algorithm
		add encryptedPassword's value to account under the key "password"; 

	if Account isn't empty:
		jsonAccount equals the result of serializing the dictionary to a jsonstring;
		save the jsonAccount to a file named Company in the folder accounts inside the install location;
	else:
		display a textbox that tells the user they need at least one username, password, or email to store account info;