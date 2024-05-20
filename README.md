<!DOCTYPE html>
<html>
<head>
</head>
<body style="margin: auto; text-align: center;">
    
<h1> Pattern Practise </h1>
<p />
<h3>Paragraphs</h3>
<li>Facade</li>
<li>Adapter</li>
<li>Builder</li>
<li>Singleton</li>


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


<h3>Builder</h3>
<p>Builder pattern is used to create instances with diffrent configurations</p>
<p>In example we could build home with any combination of parameters: Garage, Garden and Swimming Pool</p>


![image](https://github.com/kadisin/PatternsPractise/assets/38622355/29f6bde6-15c3-4500-b9c2-2f1e9e8efb0d)




<h3> Singleton </h3>
<p>Singleton is pattern to have only one instance of object in global use</p>
<p>Example is object to communication with database</p>


![image](https://github.com/kadisin/PatternsPractise/assets/38622355/e2f8ef60-1b2d-42ab-9976-735f573b002f)


 
</body>
</html>
