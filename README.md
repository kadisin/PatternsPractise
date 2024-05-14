<!DOCTYPE html>
<html>
<head>
</head>
<body style="margin: auto; text-align: center;">
    
<h1> Pattern Practise </h1>
<p />
<h3>Paragraphs</h3>
<li>Facade/li>
<li>Adapter</li>

 <h3> Facade </h3>
 <p> Facade is pattern to manage subsystems </p>
 <p>In example we want to manage car open and close - we have already wroten three subsystems - manage door, temperature inside and air conditioner</p>
 <p>We could use facade to manage that subsystem as a one simple system/interface</p>

 ![image](https://github.com/kadisin/PatternsPractise/assets/38622355/f896a45c-c3d2-4a7b-befa-2ba848202335)



 <h3> Adapter </h3>
 <p>Adapter is pattern to convert data/objects</p>
 <p>In example we have client who have xml data and service that need json data to send</p>
 <p>We have to implement adapter in the middle - some instance that will convert client data to correct data what service need</p>
 <p>In example we cast string -> string but in more serious implementation adapter interface could look like:</p>
 <p>public JsonData XmlToJsonConvert(XmlData data)</p>

 ![image](https://github.com/kadisin/PatternsPractise/assets/38622355/eb61392e-c24b-4b10-87f8-0e46e2ea7507)


 
</body>
</html>
