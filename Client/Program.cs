const string address = "http://localhost:8080/";
HttpClient httpClient = new HttpClient();

var response = await httpClient.GetAsync(address);

System.Console.WriteLine(response.StatusCode);