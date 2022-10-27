# castanedaPAddTwoNumbersEndpoint

Created an Endpoint that allows user to input two numbers in the URL and then a function to add them together and returns result.

Peer Review by; Kent T. Works like its intended to do. Like I got to see the problem and not just the sum of the number.

To run this program you must open Postman app. Then from IDE you use to open code file run the Debug. Once you run it get the localhost server information and copy and paste it the the url box in Postman. Add the name of the Controller minus the "Controller" portion of the file name. Then add the route name. Use this format (localhost/7126/controllernamehere/routenamehere). You will need to write a JSON format code in Postman under body/raw/JSON once in the JSON file input the JSON format code like this {"variablename" : "your input here"}. The "variablename" can be found under Models folder in IDE. After you finish inputing the JSON code click "send" next to the url box in Postman. You will then see the result in the Postman console.

If api does not have models follow this format in the URL (localhost/7126/controllername/routename/{num1}/{num2}
