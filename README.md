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


 <h3> Adapter </h3>
 <p>Adapter is pattern to convert data/objects</p>
 <p>In example we have client who have xml data and service that need json data to send</p>
 <p>We have to implement adapter in the middle - some instance that will convert client data to correct data what service need</p>
 <p>In example we cast string -> string but in more serious implementation adapter interface could look like:</p>
 <p>public JsonData XmlToJsonConvert(XmlData data)</p>

 
</body>
</html>
