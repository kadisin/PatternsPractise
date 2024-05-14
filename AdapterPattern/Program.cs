/*
 * 
 * Adapter convert data from client to service (in this case types are same string -> string but other formats
 * Client have data xml format but service need json format - adapter is in the middle to convert data to use in service
 * 
 */

using AdapterPattern.Adapter;
using AdapterPattern.Models;
using AdapterPattern.Service;

Client client = new Client();
Console.WriteLine("Client xml data:");
Console.WriteLine(client.ClientData.Xml);


IClientAdapter adapter = new ClientAdapter();
var jsonData = adapter.XmlToJsonConvert(client.ClientData.Xml);
//now we got data in json format
//we could use service with json data
ISendService sendService = new SendService();
sendService.Send(jsonData);
Console.WriteLine(jsonData);

/* Console logs:
 * 
 * Client xml data:
<?xml version='1.0'?>
    <SquidGame>
      <Genre>Thriller</Genre>
      <Rating Type='Imdb'>8.1</Rating>
      <Stars>Lee Jung-jae</Stars>
      <Stars>Park Hae-soo</Stars>
      <Budget />
    </SquidGame>
{"?xml":{"@version":"1.0"},"SquidGame":{"Genre":"Thriller","Rating":{"@Type":"Imdb","#text":"8.1"},"Stars":["Lee Jung-jae","Park Hae-soo"],"Budget":null}}

 */ 

